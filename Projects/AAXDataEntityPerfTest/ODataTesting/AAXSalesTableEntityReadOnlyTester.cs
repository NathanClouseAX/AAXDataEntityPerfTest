using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AuthenticationUtility;
//using Microsoft.OData.Client;
using Microsoft.Dynamics.DataEntities;

using System.Web;
using System.Data;
using System.IO;

using System.Diagnostics;

namespace ODataTesting
{
    public class AAXSalesTableEntityReadOnlyTester : SalesOrderTester
    {
        public static string logTemplate = "";
        public static string Entity = "AAXSalesTableEntityReadOnly";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            AAXSalesTableReadOnly AAXSalesTableReadOnly = context.AAXSalesTablesReadOnly.Where(x => x.SalesId == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runReads(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string customerAccount, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.AAXSalesTablesReadOnly.Where(x => x.dataAreaId == DataAreaId && x.CustAccount == customerAccount).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runReadWithSelect(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            //approximately what is shown in the SalesTableListPage form
            //Order Type, Channel not available, Release Status not available
            //declined on SalesTaker
            var AAXSalesTablesReadOnly = context.AAXSalesTablesReadOnly.Where(x => x.SalesId == SalesOrderNumber && x.dataAreaId == DataAreaId)
                                                       .Select(x => new { x.SalesId, x.CustAccount, x.InvoiceAccount, x.SalesStatus, x.dataAreaId })
                                                       .First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();
        }

        public static void runReadsWithSelect(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string customerAccount, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.AAXSalesTablesReadOnly.Where(x => x.dataAreaId == DataAreaId && x.CustAccount == customerAccount)
                                          .Select(x => new { x.SalesId, x.CustAccount, x.InvoiceAccount, x.SalesStatus, x.dataAreaId })
                                          .Take(count)
                                          .ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }


    }
}
