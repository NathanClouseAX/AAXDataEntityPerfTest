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


namespace ConsoleApp1
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\log.txt";



        static void Main(string[] args)
        {
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);
            var context = new Resources(oDataUri);

            
            context.BuildingRequest += (sender, e) =>
            {
                var uriBuilder = new UriBuilder(e.RequestUri);
                // Requires a reference to System.Web and .NET 4.6.1
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
            /*
            if (File.Exists(filePath))
            {
                // delete file and init a file to write to.
                File.Delete(filePath);
            }

            StreamWriter stream = File.CreateText(filePath);
            stream.WriteLine("Entity,TestType, Workload, Duration");
            stream.Flush();
            stream.Close();
            
            Console.WriteLine("Start.");

            SalesValues values;

            SalesOrderTester.getRandomSet(10);

            #region SalesOrderHeaderV2 Tests
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);         
            }

            //fixed read
            values = SalesOrderHeaderV2Tester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2Tester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random 10 reads


            //repetitive 10 reads
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2Tester.runReads(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read10, SalesOrderHeaderV2Tester.getRandomCombination().DataAreaId, "", 10);
            }


            #endregion


            for (int i = 0; i < 100; i++)
            {

                values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //done
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.getRandomCombination();
                SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
                //stream.WriteLine("SalesOrderHeaderV2EntityReadOnlyNoGlobalization," + sw.Elapsed.TotalMilliseconds.ToString());
            }

            //repetitive
            values = SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }



            //random
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityOnlySalesTableTester.getRandomCombination();
                SalesOrderHeaderV2EntityOnlySalesTableTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = SalesOrderHeaderV2EntityOnlySalesTableTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityOnlySalesTableTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }


            //random
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityDSReadOnlyTester.getRandomCombination();
                SalesOrderHeaderV2EntityDSReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = SalesOrderHeaderV2EntityDSReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityDSReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random
            for (int i = 0; i < 100; i++)
            {
                values = AAXSalesTableEntityTester.getRandomCombination();
                AAXSalesTableEntityTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = AAXSalesTableEntityTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                AAXSalesTableEntityTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random
            for (int i = 0; i < 100; i++)
            {
                values = AAXSalesTableEntityReadOnlyTester.getRandomCombination();
                AAXSalesTableEntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = AAXSalesTableEntityReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                AAXSalesTableEntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }
            */
            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();
        }
    }
}
