/* Original work by Brad Bateman (https://twitter.com/BradBateTech)
 * https://batetech.wordpress.com/2021/05/28/d365-odata-and-custom-service-429-throttling-simulation-dev-vm-setups/
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;

namespace ODataThrottlingSim
{
    public class CustomODataThottler : IHttpModule
    {
        int throttlePercent_OData = 0;
        int throttlePercent_CustomService = 0;
        string retryAfterInSeconds;
        List<Tuple<string, int, string>> throttleURLs;

        string throttleRequestTypes;

        public void Init(HttpApplication application)
        {
            //---------------------------------------------
            //GLOBAL THROTTLING RULES:
            retryAfterInSeconds = "3"; //the "Retry-After" HTTP header value to use if throttling.  Time to wait before retry in seconds
            throttlePercent_OData = 1; //0 for no throttling, or any int between 1 and 100 to throttle a percentage of all oData requests.
            throttlePercent_CustomService = 1; //0 for no throttling, or any int between 1 and 100 to throttle a percentage of all custom service requests.

            //If you don't want to throttle a specific request type (such as reads/GET) then remove it below.
            throttleRequestTypes = "GET|POST|PATCH|PUT|DELETE";
            //---------------------------------------------
            //INDIVIDUAL URL THROTTLING RULES:
            //use this if you want to throttle specific URLs, entities, requests differently
            // Each rule is implemented as a Tuple, as: 
            //   Item1: URL RegEx pattern to match
            //   Item2: % of requests to throttle (0-100), 
            //   Item3: HTTP Request Types regex pattern to match (get,post,etc.). To match all, use ".*"
            throttleURLs = new List<Tuple<string, int, string>>
            {   //==================================================
                //EXAMPLES:                 
                //Tuple.Create(EntityNameToRegEx("Vendors"), 50, "GET"), //Example 1: throttle 50% of GET requests to the Vendors entity
                //Tuple.Create(WildCardToRegex(@"*/data/Vendor*"), 30, "GET"), //Example 2: thottle 30% of GET requests to the entities that start with "Vendor"
                //Tuple.Create(@".*\/data\/VendorInvoiceLines([\(\?\/%#]|$){1}.*", 50, "POST|PATCH"), //Example 3: throttle 50% of Post or Patch requests to the VendorInvoiceLines entity followed by one of the following chars: "(?/%#" or end of line
                //Tuple.Create(WildCardToRegex(@"*/data/DataManagementDefinitionGroups*ExportToPackage*"), 0, ".*") //Example 4: don't throttle any requests to DataManagementDefinitionGroups, ExportToPackage action
                //Tuple.Create(WildCardToRegex(@"*/data/ConturaODataActionCallers*Microsoft.Dynamics.DataEntities.xxceVendInvoiceUnLock*"), 0, ".*") //Example 4: don't throttle this request to a specific oData action, for any request type
                //==================================================
                //GL VALIDATION RELATED DATA ENTITIES: throttle 30% of all requests. 
                //Tuple.Create(EntityNameToRegEx("FinancialDimensionValues"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("MainAccounts"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("AccountStructures"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("AdvancedRules"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("AdvancedRuleCriteria"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("LedgerAdvancedRuleStructures"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("FiscalPeriods"), 30, ".*"),
                //Tuple.Create(EntityNameToRegEx("LedgerFiscalPeriods"), 30, ".*"),
                //==================================================
            };
            //---------------------------------------------

            application.BeginRequest += Application_ThrottleSim;
        }

        private void Application_ThrottleSim(object sender, EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            HttpContext context = application.Context;

            try
            {
                bool shouldThrottle = false;
                bool foundURLMatch = false; //used to know if we found a match on this URL and request type, so we can stop applying throttling rules
                string url = context.Request.Url.ToString();

                context.Response.Headers.Add("X-CustomODataThottler", "Active"); //to let us know that our custom module fired
                //----------------------------------
                //Individual URL overrides
                foreach (Tuple<string, int, string> t in throttleURLs)
                {
                    if (Regex.IsMatch(url, t.Item1, RegexOptions.IgnoreCase))
                    {
                        if (Regex.IsMatch(context.Request.RequestType, t.Item3, RegexOptions.IgnoreCase))
                        {
                            foundURLMatch = true;
                            context.Response.Headers.Add("X-CustomODataThottler-URLPatternMatch", string.Format("RequestType: {0}; URL: {1}; {2}%; Types: {3}", context.Request.RequestType, t.Item1, t.Item2, t.Item3));
                        }
                        else
                        {
                            //the request type doesn't match this throttling rule, continue to the next rule
                            continue;
                        }

                        if (t.Item2 <= 0)
                        {
                            shouldThrottle = false;
                        }
                        else if ((new Random().Next(1, 100)) <= t.Item2)
                        {
                            SimulateThrottling(context);
                            return;
                        }
                        break; //just keep first match
                    }
                }
                if (foundURLMatch)
                {
                    //if we found a match by specific URL, and haven't throttled yet, then exit now
                    return;
                }
                //----------------------------------
                if (!Regex.IsMatch(context.Request.RequestType, throttleRequestTypes, RegexOptions.IgnoreCase))
                {
                    //this request type is not setup for trottling
                    context.Response.Headers.Add("X-CustomODataThottler-RequestType-NoThrottle", string.Format("No match for request type: '{0}', using pattern: '{1}'", context.Request.RequestType, throttleRequestTypes));
                    return;
                }

                //OData
                if (url.IndexOf(@"/data/", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    context.Response.Headers.Add("X-CustomODataThottler-OData-Percent", throttlePercent_OData.ToString());
                    //this is an oData call
                    if (throttlePercent_OData > 0 && (new Random().Next(1, 100)) <= throttlePercent_OData)
                    {
                        shouldThrottle = true;
                    }
                }
                //Custom Service
                else if (url.IndexOf(@"/api/services/", StringComparison.CurrentCultureIgnoreCase) >= 0  //json
                        || url.IndexOf(@"/soap/services/", StringComparison.CurrentCultureIgnoreCase) >= 0 //soap
                        )
                {
                    context.Response.Headers.Add("X-CustomODataThottler-CustomService-Percent", throttlePercent_CustomService.ToString());
                    //this is a call to a Custom Service endpoint
                    if (throttlePercent_CustomService > 0 && (new Random().Next(1, 100)) <= throttlePercent_CustomService)
                    {
                        shouldThrottle = true;
                    }
                }

                if (shouldThrottle)
                {
                    SimulateThrottling(context);
                }
            }
            catch (System.Threading.ThreadAbortException)
            {
                //do nothing, this is expected if we call Request.End
            }
            catch (Exception ex)
            {
                //eat exceptions so we don't kill the system due to invalid regex strings, etc.
                //HACK: just add to the response header instead (there is probably a better way to do this)
                context.Response.Headers.Add("X-CustomODataThottler-ERROR", ex.ToString());
            }
        }

        private void SimulateThrottling(HttpContext context)
        {
            context.Response.Clear();
            context.Response.Write("Too many requests - CustomODataThottler custom HttpModule used for testing");
            context.Response.Headers.Add("Retry-After", retryAfterInSeconds); //in seconds
            context.Response.StatusCode = 429;
            context.Response.End();
        }

        private string EntityNameToRegEx(string entityName)
        {
            return @".*\/data\/" + entityName + @"([\(\?\/%#]|$){1}.*";
        }
        private String WildCardToRegex(String value)
        {
            return "^" + Regex.Escape(value).Replace("\\*", ".*") + "$";
        }

        public void Dispose()
        {
            //nothing to do here, but required for IHttpModule
        }
    }
}