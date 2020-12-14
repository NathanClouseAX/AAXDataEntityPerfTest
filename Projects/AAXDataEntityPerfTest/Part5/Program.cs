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

namespace Part5
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part5-UAT.txt";

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

            Console.Write("Warming.");

            context.SalesOrderHeadersV2.FirstOrDefault();
            Console.Write(".");
            Console.WriteLine(".");


            Console.WriteLine("Starting...");

            SalesValues values;

            #region SalesOrderHeaderV2 Tests
            Console.WriteLine("Starting SalesOrderHeaderV2 Tests");

            int loopCount = 100;

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }


            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomInventSite();
                SalesOrderHeaderV2Tester.runOneReadOnInventSiteId(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadInventSite, values.InventSiteId, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomInventLocation();
                SalesOrderHeaderV2Tester.runOneReadOnInventLocationId(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadInventLocation, values.InventLocationid, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomEmail();
                SalesOrderHeaderV2Tester.runOneReadOnSalesEmail(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadEmail, values.Email, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomSalesName();
                SalesOrderHeaderV2Tester.runOneReadOnSalesName(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadSalesName, values.SalesName, values.DataAreaId);
            }

            //--
            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.SalesId, 10);
            }


            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomInventSite();
                SalesOrderHeaderV2Tester.runReadsOnInventSiteId(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10InventSite, values.DataAreaId, values.InventSiteId, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomInventLocation();
                SalesOrderHeaderV2Tester.runReadsOnInventLocationId(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10InventLocation, values.DataAreaId, values.InventLocationid, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomEmail();
                SalesOrderHeaderV2Tester.runReadsOnSalesEmail(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10Email, values.DataAreaId,  values.Email, 10);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomSalesName();
                SalesOrderHeaderV2Tester.runReadsOnSalesName(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10SalesName, values.DataAreaId, values.SalesName, 10);
            }

            #endregion

            //but is index over-specification an issue?
            //ReadCustIdx, ReadStatusCustAccidx, ReadSalesTypeIdx, ReadCustCreatedDateIdx,
            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneCustIdxRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadCustIdx, values.CustAccount, values.SalesId, values.PurchOrderFormNum, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneStatusCustAccountIdxRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadStatusCustAccidx, values.SalesStatus, values.CustAccount, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneSalesTypeIdxRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadSalesTypeIdx, values.SalesId, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneCustCreatedDateIdxRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadCustCreatedDateIdx, values.CustAccount, values.CreatedDateTime, values.DataAreaId);
            }

            for (int i = 0; i < loopCount; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomGarbageCombination();
                SalesOrderHeaderV2Tester.runOneGarbageRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadGarbage, values);
            }
            //


            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();

        }
    }
}
