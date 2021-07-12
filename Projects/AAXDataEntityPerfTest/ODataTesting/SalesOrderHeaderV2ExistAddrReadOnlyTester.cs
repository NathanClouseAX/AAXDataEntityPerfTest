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
    public class SalesOrderHeaderV2ExistAddrReadOnlyTester : SalesOrderTester
    {
        public static string logTemplate = "{Entity},{testType},{testWorkload},{sw.Elapsed.TotalMilliseconds.ToString()}";
        public static string Entity = "SalesOrderHeaderV2ExistAddrReadOnly";

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
                    SalesOrderHeaderV2ExistAddrReadOnly salesOrderHeaderV2ExistAddrReadOnly = context.SalesOrderHeaderV2ExistAddrReadOnlys.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();


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

        public static void runReads(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string customerAccount , int count)
        {
            int tryCount = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();

            while (true)
            {
                try
                {
                    tryCount++;
                    context.SalesOrderHeaderV2ExistAddrReadOnlys.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount).Take(count).ToList();

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
            stream.WriteLine(Entity +"," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            
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
            var SalesOrderHeaderV2ExistAddrReadOnly = context.SalesOrderHeaderV2ExistAddrReadOnlys.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId)
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

            context.SalesOrderHeaderV2ExistAddrReadOnlys.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount)
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
