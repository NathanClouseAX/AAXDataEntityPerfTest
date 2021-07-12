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

namespace ODataTesting
{
    public class SalesOrderHeaderV2EntityDSReadOnlyTester : SalesOrderTester
    {
        public static string logTemplate = "";
        public static string Entity = "SalesOrderHeaderV2EntityDSReadOnly";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            int tryCount = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();

            while (true)
            {
                try
                {
                    tryCount++;
                    SalesOrderHeaderV2EntityDSReadOnly SalesOrderHeaderV2EntityDSReadOnly = context.SalesOrderHeadersV2EntityDSReadOnly.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();


                    break;

                }
                catch (Exception e)
                {
                    if (tryCount >= 3)
                    {
                        throw (e);
                    }
                    sw.Reset();
                    sw.Start();
                }
            }

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runReads(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string customerAccount, int count)
        {
            int tryCount = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();

            while (true)
            {
                try
                {
                    tryCount++;
                    context.SalesOrderHeadersV2EntityDSReadOnly.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount).Take(count).ToList();

                    break;

                }
                catch (Exception e)
                {
                    if (tryCount >= 3)
                    {
                        throw (e);
                    }
                    sw.Reset();
                    sw.Start();
                }
            }

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
            var SalesOrderHeadersV2EntityDSReadOnly = context.SalesOrderHeadersV2EntityDSReadOnly.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId)
                                                                                                  .Select(x => new { x.SalesOrderNumber, x.OrderingCustomerAccountNumber, x.InvoiceCustomerAccountNumber, x.SalesOrderStatus, x.dataAreaId })
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

            context.SalesOrderHeadersV2EntityDSReadOnly.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount)
                                                        .Select(x => new { x.SalesOrderNumber, x.OrderingCustomerAccountNumber, x.InvoiceCustomerAccountNumber, x.SalesOrderStatus, x.dataAreaId })
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
