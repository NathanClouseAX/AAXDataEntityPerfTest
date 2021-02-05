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

namespace Part9
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part9.txt";

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

            SalesValues values;

            StreamWriter stream = File.CreateText(filePath);
            stream.WriteLine("Entity, TestType, Workload, Duration");
            stream.Flush();
            stream.Close();

            Console.WriteLine("Connected To " + ClientConfiguration.Default.UriString);

            Stopwatch sw = new Stopwatch();

            context.SalesOrderHeadersV2.FirstOrDefault();
            context.SalesOrderLines.FirstOrDefault();
            context.SalesOrderHeadersV2EntityOnlySalesTablePostLoad.FirstOrDefault();
            context.SalesOrderHeadersV2EntityOnlySalesTablePostLoadExtended.FirstOrDefault();

            //SalesOrderLineV2Tester.runGetAllPagesSkipTake(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadAllPagesSkipTake);

            //SalesOrderLineV2Tester.runGetAllPages(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadAllPagesQuery);

            /*
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityOnlySalesTableTester.getRandomCombination();
                SalesOrderHeaderV2EntityOnlySalesTableTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }
            */

            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityOnlySalesTablePostLoadTester.getRandomCombination();
                SalesOrderHeaderV2EntityOnlySalesTablePostLoadTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadPostLoad, values.SalesId, values.DataAreaId);
            }
            

            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityOnlySalesTablePostLoadExtendedTester.getRandomCombination();
                SalesOrderHeaderV2EntityOnlySalesTablePostLoadExtendedTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadPostLoadExtended, values.SalesId, values.DataAreaId);
            }

            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();
        }

    }
}
