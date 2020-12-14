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

using System.Diagnostics;

using ODataTesting;

using System.Threading;

namespace Part8
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part8.txt";

        

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
            stream.WriteLine("Entity, TestType, Workload, Duration");
            stream.Flush();
            stream.Close();

            Console.WriteLine("Connected To " + ClientConfiguration.Default.UriString);

            SalesValues values;

            int loopCount = 100;

            Stopwatch sw = new Stopwatch();

            context.SalesOrderHeadersV2.FirstOrDefault();
            context.SalesOrderLines.FirstOrDefault();

            sw.Start();
            
            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombinationWithAtLeast1Line();
                SalesOrderLineV2Tester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombinationWithAtLeast1Line();
                SalesOrderLineV2Tester.runOneExpandedRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadExpanded, values.SalesId, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombinationWithAtLeast1Line();
                SalesOrderLineV2Tester.runOneCombinedRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadCombined, values.SalesId, values.DataAreaId);
            }
             
            //{  "000375", "US-025", "", "3", "2016-01-16T08:40:48", "usmf" },
            /*
            AAXSalesTable aAXSalesTable = context.AAXSalesTables.Expand(x => x.AAXSalesLine).Where(x => x.SalesId == "000375" && x.dataAreaId == "USMF").First();

            foreach( AAXSalesLine line in aAXSalesTable.AAXSalesLine)
            {

            }
            */


            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();

        }
    }
}
