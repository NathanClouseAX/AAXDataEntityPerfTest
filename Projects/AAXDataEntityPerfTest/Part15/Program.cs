using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AuthenticationUtility;
using Microsoft.OData.Client;
using Microsoft.Dynamics.DataEntities;

using System.Web;
using System.Data;
using System.IO;

using System.Threading;


using System.Diagnostics;

using ODataTesting;

using System.Threading;

namespace Part15
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part15.txt";

        public static void ContextReceivingResponse(object sender, Microsoft.OData.Client.ReceivingResponseEventArgs e)
        {
            var response = e.ResponseMessage as HttpWebResponseMessage;
            var statusCode = response.StatusCode;
            var headers = response.Headers;

            Resources context = (Resources)sender;

            int retrySeconds = 5;

            if (statusCode == 429)
            {
                if (response.GetHeader("Retry-After") != "")
                {
                    var val = response.GetHeader("Retry-After");
                    retrySeconds = int.Parse(val);
                }

                Console.WriteLine("Caught 429, waiting {0}", retrySeconds);

                Thread.Sleep(TimeSpan.FromSeconds(retrySeconds));

            }

        }


        static void Main(string[] args)
        {
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);
            var context = new Resources(oDataUri);

            context.BuildingRequest += (sender, e) =>
            {
                var uriBuilder = new UriBuilder(e.RequestUri);
                // Requires a reference to System.Web and .NET 4.6.1+
                var paramValues = HttpUtility.ParseQueryString(uriBuilder.Query);
                if (paramValues.GetValues("cross-company") == null)
                {
                    paramValues.Add("cross-company", "true");
                    uriBuilder.Query = paramValues.ToString();
                    e.RequestUri = uriBuilder.Uri;
                }
            };


            context.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(delegate (object sender, SendingRequest2EventArgs e)
            {
                var authenticationHeader = OAuthHelper.GetAuthenticationHeader(useWebAppAuthentication: true);
                e.RequestMessage.SetHeader(OAuthHelper.OAuthHeader, authenticationHeader);
            });



            StreamWriter stream = File.CreateText(filePath);
            stream.WriteLine("Entity,TestType, Workload, Duration");
            stream.Flush();
            stream.Close();

            Console.WriteLine("Warming....");
            context.SalesOrderHeadersV2.FirstOrDefault();
            context.SalesOrderHeadersV2EntityDSReadOnly.FirstOrDefault();
            context.SalesOrderHeadersV2EntityOnlySalesTable.FirstOrDefault();
            context.SalesOrderHeadersV2EntityReadOnly.FirstOrDefault();
            context.SalesOrderHeadersV2EntityReadOnlyNoGlobalization.FirstOrDefault();
            context.SalesOrderHeaderV2ExistAddrReadOnlys.FirstOrDefault();
            context.AAXSalesTables.FirstOrDefault();
            context.AAXSalesTablesReadOnly.FirstOrDefault();


            Console.WriteLine("Starting...");

            SalesValues values;

            #region SalesOrderHeaderV2 Tests
            Console.WriteLine("Starting SalesOrderHeaderV2 Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneReadCustomThrottling(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }
            
            #endregion

            #region SalesOrderheaderV2ReadOnly Tests
            Console.WriteLine("Starting SalesOrderheaderV2ReadOnly Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }
            
            #endregion
            

            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();

        }
    }
}
