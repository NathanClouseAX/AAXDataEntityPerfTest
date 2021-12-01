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

namespace Part16
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part16.txt";

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
            context.CustomersV2.FirstOrDefault();
            context.CustomersV3.FirstOrDefault();
            context.AAXCustomersV3.FirstOrDefault();
            context.AAXCustomersV4.FirstOrDefault();
            context.AAXCustomersV5.FirstOrDefault();



            Console.WriteLine("Starting...");

            CustomerValues values;

            //get some values for standard entity for customers, V3
            #region CustomerV3Tester Tests
            Console.WriteLine("Starting CustomerV3 Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = CustomerV3Tester.getRandomCombination();
                CustomerV3Tester.runOneRead(context, filePath, CustomerTester.TestType.Random, CustomerTester.TestWorkload.Read, values.AccountNum, values.DataAreaId);
            }
            #endregion

            //get some values for AAX v3
            #region AAXCustomerV3Tester Tests
            Console.WriteLine("Starting AAXCustomerV3 Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = AAXCustomerV3Tester.getRandomCombination();
                AAXCustomerV3Tester.runOneRead(context, filePath, CustomerTester.TestType.Random, CustomerTester.TestWorkload.Read, values.AccountNum, values.DataAreaId);
            }
            #endregion

            //get some vlaues for AAX V4
            Console.WriteLine("Starting AAXCustomerV4 Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = AAXCustomerV4Tester.getRandomCombination();
                AAXCustomerV4Tester.runOneRead(context, filePath, CustomerTester.TestType.Random, CustomerTester.TestWorkload.Read, values.AccountNum, values.DataAreaId);
            }

            //get some values for AAX V5
            Console.WriteLine("Starting AAXCustomerV4 Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = AAXCustomerV5Tester.getRandomCombination();
                AAXCustomerV5Tester.runOneRead(context, filePath, CustomerTester.TestType.Random, CustomerTester.TestWorkload.Read, values.AccountNum, values.DataAreaId);
            }
        }
    }
}
