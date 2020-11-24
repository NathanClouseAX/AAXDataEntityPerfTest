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
    public class SalesOrderHeaderV2Tester : SalesOrderTester
    {
        public static string logTemplate = "{Entity},{testType},{testWorkload},{sw.Elapsed.TotalMilliseconds.ToString()}";
        public static string Entity = "SalesOrderHeaderV2";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneCustIdxRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, String CustAccount, string SalesOrderNumber, String PurchOrderFormNum, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber)
                                                                               .Where(x => x.OrderingCustomerAccountNumber == CustAccount)
                                                                               .Where(x => x.CustomersOrderReference == PurchOrderFormNum)
                                                                               .Where(x => x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneStatusCustAccountIdxRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, int SalesStatus, string CustAccount, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderStatus == (Microsoft.Dynamics.DataEntities.SalesStatus)SalesStatus)
                                                                               .Where(x => x.OrderingCustomerAccountNumber == CustAccount)
                                                                               .Where(x => x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneSalesTypeIdxRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesId, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            //entity already has a filter on salesType of Sales
            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesId)
                                                                               .Where(x => x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneCustCreatedDateIdxRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string CustAccount, DateTimeOffset CreatedDateTime, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.OrderingCustomerAccountNumber == CustAccount)
                                                                               .Where(x => x.OrderCreationDateTime >= CreatedDateTime.AddDays(-1))
                                                                               .Where(x => x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneGarbageRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, SalesValues salesValues)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == salesValues.SalesId)
                                                                               .Where(x => x.OrderingCustomerAccountNumber == salesValues.CustAccount)
                                                                               .Where(x => x.CustomersOrderReference == salesValues.PurchOrderFormNum)
                                                                               .Where(x => x.SalesOrderStatus == (Microsoft.Dynamics.DataEntities.SalesStatus)salesValues.SalesStatus)
                                                                               //.Where(x => x.OrderCreationDateTime >= salesValues.CreatedDateTime.AddDays(-1))
                                                                               .Where(x => x.Email == salesValues.Email)
                                                                               .Where(x => x.DefaultShippingSiteId == salesValues.InventSiteId)
                                                                               .Where(x => x.DefaultShippingWarehouseId == salesValues.InventLocationid)
                                                                               .Where(x => x.SalesOrderName == salesValues.SalesName)
                                                                               .Where(x => x.dataAreaId == salesValues.DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }


        /*
        public static void runOneReadOnSalesRecId(Resources context, string filePath, TestType testType, TestWorkload testWorkload, Int64 SalesRecId, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.RecId == SalesRecId && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }
        */

            public static void runOneReadOnInventSiteId(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string InventSiteId, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.DefaultShippingSiteId == InventSiteId && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runReadsOnInventSiteId(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string InventSiteId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.DefaultShippingSiteId == InventSiteId).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runOneReadOnInventLocationId(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string InventLocationId, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.DefaultShippingWarehouseId == InventLocationId && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runReadsOnInventLocationId(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string InventLocationId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.DefaultShippingWarehouseId == InventLocationId).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }


        public static void runOneReadOnSalesName(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesName, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderName == SalesName && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runReadsOnSalesName(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string SalesName, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.SalesOrderName == SalesName).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runOneReadOnSalesEmail(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesEmail, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.Email == SalesEmail && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runReadsOnSalesEmail(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string SalesEmail, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.Email == SalesEmail).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }



        public static void runReads(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string customerAccount , int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount).Take(count).ToList();

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
            var SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId)
                                                                .Select(x => new { x.SalesOrderNumber, x.OrderingCustomerAccountNumber, x.InvoiceCustomerAccountNumber, x.SalesOrderStatus, x.dataAreaId} )
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

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount)
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
