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

namespace Part6
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part6.txt";

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

            Console.WriteLine("Connected To " + ClientConfiguration.Default.UriString);

            SalesValues values;

            Console.Write("Warming.");
            context.SalesOrderHeadersV2.FirstOrDefault();
            Console.Write(".");
            Console.WriteLine(".");


            #region SalesOrderHeaderV2 Tests
            Console.WriteLine("Starting SalesOrderHeaderV2 Tests");

            int loopCount = 100;

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReadsWithOrderByAsc(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10WithOrderByAscOnIndex, values.DataAreaId, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReadsWithOrderByDesc(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Ready10WithOrderByDescOnIndex, values.DataAreaId, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReadsWithOrderByAscOnRequestedShippingDate(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10WithOrderByAscNotOnIndex, values.DataAreaId, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReadsWithOrderByDescOnRequestedShippingDate(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10WithOrderByDescNotOnIndex, values.DataAreaId, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReadsWithOrderByAscOnSalesOrderProcessingStatus(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10WithOrderByAscOnCalculatedField, values.DataAreaId, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReadsWithOrderByDescOnSalesOrderProcessingStatus(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10WithOrderByDescOnCalculatedField, values.DataAreaId, 10);
            }

            //salesOrderProcessingStat


            #endregion



            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();

        }
    }
}
