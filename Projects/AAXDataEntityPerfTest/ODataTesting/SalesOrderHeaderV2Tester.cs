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

        public static string runOneReadThread(Resources context, int threadCount,  string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            return(Entity + "," + threadCount  + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

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

        public static void runReadsWithOrderByAsc(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId).OrderBy(x => x.SalesOrderNumber).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }


        public static void runReadsWithOrderByDesc(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId).OrderByDescending(x => x.SalesOrderNumber).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runReadsWithOrderByAscOnRequestedShippingDate(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId).OrderBy(x => x.RequestedShippingDate).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runReadsWithOrderByDescOnRequestedShippingDate(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId).OrderByDescending(x => x.RequestedShippingDate).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runReadsWithOrderByAscOnSalesOrderProcessingStatus(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId).OrderBy(x => x.SalesOrderProcessingStatus).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }

        public static void runReadsWithOrderByDescOnSalesOrderProcessingStatus(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId).OrderByDescending(x => x.SalesOrderProcessingStatus).Take(count).ToList();

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

            //approximately what is shown in the AAXSalesTableListPage form
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

        public static void createWithCompoundEntityMinimum(Resources context, 
                                                           string filePath, 
                                                           TestType testType, 
                                                           TestWorkload testWorkload, 
                                                           string DataAreaId, 
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            DataServiceCollection<SalesOrderHeaderV2> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2>(context);
            SalesOrderHeaderV2 salesOrderHeaderV2 = new SalesOrderHeaderV2();

            SalesOrderCollection.Add(salesOrderHeaderV2);

            // Required Fields
            salesOrderHeaderV2.OrderingCustomerAccountNumber = customerAccount;
            salesOrderHeaderV2.InvoiceCustomerAccountNumber = customerAccount;
            salesOrderHeaderV2.dataAreaId = DataAreaId;
            salesOrderHeaderV2.CurrencyCode = "USD";
            salesOrderHeaderV2.LanguageId = "en-us";

            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created Sales Order " + salesOrderHeaderV2.SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }

        public static void createWithCompoundEntityMaximum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            DataServiceCollection<SalesOrderHeaderV2> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2>(context);
            SalesOrderHeaderV2 salesOrderHeaderV2 = new SalesOrderHeaderV2();

            SalesOrderCollection.Add(salesOrderHeaderV2);

            // Required Fields
            salesOrderHeaderV2.OrderingCustomerAccountNumber = customerAccount;
            salesOrderHeaderV2.InvoiceCustomerAccountNumber = customerAccount;
            salesOrderHeaderV2.dataAreaId = DataAreaId;
            salesOrderHeaderV2.CurrencyCode = "USD";
            salesOrderHeaderV2.LanguageId = "en-us";

            // Optional Fields
            salesOrderHeaderV2.SalesOrderPromisingMethod = SalesDeliveryDateControlType.CTP;
            salesOrderHeaderV2.DeliveryModeCode = "10";
            salesOrderHeaderV2.DeliveryTermsCode = "FOB";
            salesOrderHeaderV2.PaymentTermsName = "Net10";
            salesOrderHeaderV2.CustomerPaymentMethodName = "Check";
            salesOrderHeaderV2.Email = "Contoso.Retail.San.Diego@customer60.consolidatedmessenger.com";
            salesOrderHeaderV2.CustomerPostingProfileId = "GEN";
            //salesOrderHeaderV2.PriceCustomerGroupCode = "03";
            //salesOrderHeaderV2.CommissionSalesRepresentativeGroupId = "01";
            salesOrderHeaderV2.SalesOrderName = "Test Sales Order Id";
            salesOrderHeaderV2.SalesOrderOriginCode = "PHONE";
            salesOrderHeaderV2.SalesOrderPoolId = "03";
            salesOrderHeaderV2.SalesTaxGroupCode = "CA";
            salesOrderHeaderV2.TaxExemptNumber = "35-12345";
            salesOrderHeaderV2.OrderResponsiblePersonnelNumber = "000002";
            salesOrderHeaderV2.OrderTakerPersonnelNumber = "000002";
            salesOrderHeaderV2.DefaultLedgerDimensionDisplayValue = "001--";

            salesOrderHeaderV2.DeliveryAddressCity = "Detroit";
            salesOrderHeaderV2.DeliveryAddressCountryRegionISOCode = "USA";
            salesOrderHeaderV2.DeliveryAddressDescription = "Delivery";
            salesOrderHeaderV2.DeliveryAddressName = "Delivery";
            salesOrderHeaderV2.DeliveryAddressStateId = "MI";
            salesOrderHeaderV2.DeliveryAddressStreet = "123 Main St";
            salesOrderHeaderV2.DeliveryAddressZipCode = "01234";


            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created Sales Order " + salesOrderHeaderV2.SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }


        public static void createWithSimpleEntityMinimum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable>(context);

            SalesOrderHeaderV2EntityOnlySalesTable SalesOrderHeaderV2EntityOnlySalesTable = new SalesOrderHeaderV2EntityOnlySalesTable();

            SalesOrderCollection.Add(SalesOrderHeaderV2EntityOnlySalesTable);

            //Required Fields
            SalesOrderHeaderV2EntityOnlySalesTable.OrderingCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.InvoiceCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.dataAreaId = DataAreaId;
            SalesOrderHeaderV2EntityOnlySalesTable.CurrencyCode = "USD";
            SalesOrderHeaderV2EntityOnlySalesTable.LanguageId = "en-us";

            //SalesOrderHeaderV2EntityOnlySalesTable.CustGroup = "30";
            //SalesOrderHeaderV2EntityOnlySalesTable.ShippingDateRequested = DateTime.UtcNow;
            //SalesOrderHeaderV2EntityOnlySalesTable.ReceiptDateRequested = DateTime.UtcNow;

            //SalesOrderHeaderV2EntityOnlySalesTable.salesordert = SalesType.Sales;
            //SalesOrderHeaderV2EntityOnlySalesTable.SalesName = "test";


            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created Sales Order " + SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }

        public static void createWithSimpleEntityMaximum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable>(context);
            SalesOrderHeaderV2EntityOnlySalesTable SalesOrderHeaderV2EntityOnlySalesTable = new SalesOrderHeaderV2EntityOnlySalesTable();


            SalesOrderCollection.Add(SalesOrderHeaderV2EntityOnlySalesTable);

            // Required Fields
            SalesOrderHeaderV2EntityOnlySalesTable.OrderingCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.InvoiceCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.dataAreaId = DataAreaId;
            SalesOrderHeaderV2EntityOnlySalesTable.CurrencyCode = "USD";
            SalesOrderHeaderV2EntityOnlySalesTable.LanguageId = "en-us";

            //SalesOrderHeaderV2EntityOnlySalesTable.CustGroup = "30";
            //SalesOrderHeaderV2EntityOnlySalesTable.ShippingDateRequested = DateTime.UtcNow;

            // Optional Fields
            SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderPromisingMethod = SalesDeliveryDateControlType.CTP;
            SalesOrderHeaderV2EntityOnlySalesTable.DeliveryModeCode = "10";
            SalesOrderHeaderV2EntityOnlySalesTable.DeliveryTermsCode = "FOB";
            SalesOrderHeaderV2EntityOnlySalesTable.PaymentTermsName = "Net10";
            SalesOrderHeaderV2EntityOnlySalesTable.CustomerPaymentMethodName = "Check";
            SalesOrderHeaderV2EntityOnlySalesTable.Email = "Contoso.Retail.San.Diego@customer60.consolidatedmessenger.com";
            SalesOrderHeaderV2EntityOnlySalesTable.CustomerPostingProfileId = "GEN";
            //SalesOrderHeaderV2EntityOnlySalesTable.PriceCustomerGroupCode = "03";
            //SalesOrderHeaderV2EntityOnlySalesTable.CommissionSalesRepresentativeGroupId = "01";
            SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderName = "Test Sales Order Id";
            SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderOriginCode = "PHONE";
            SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderPoolId = "03";
            SalesOrderHeaderV2EntityOnlySalesTable.SalesTaxGroupCode = "CA";
            SalesOrderHeaderV2EntityOnlySalesTable.TaxExemptNumber = "35-12345";
            //SalesOrderHeaderV2EntityOnlySalesTable.OrderResponsiblePersonnelNumber = "000002";
            //SalesOrderHeaderV2EntityOnlySalesTable.OrderTakerPersonnelNumber = "000002";
            //SalesOrderHeaderV2EntityOnlySalesTable.DefaultLedgerDimensionDisplayValue = "001--";

            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressCity = "Detroit";
            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressCountryRegionISOCode = "USA";
            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressDescription = "Delivery";
            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressName = "Delivery";
            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressStateId = "MI";
            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressStreet = "123 Main St";
            //SalesOrderHeaderV2EntityOnlySalesTable.DeliveryAddressZipCode = "01234";

            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created Sales Order " + SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }



        public static void updateWithCompoundEntityMinimum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string SalesOrderNumber)
        {

            Stopwatch sw = new Stopwatch();

            var SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();
            if (SalesOrderHeaderV2.SalesOrderNumber != null)
            {
                DataServiceCollection<SalesOrderHeaderV2> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2>(context);
                string salesURL = SalesOrderHeaderV2.URL;

                // replace whatever is there with this trash
                salesURL = "http://www." + Guid.NewGuid().ToString() + ".com";

                sw.Start();
                SalesOrderCollection.Add(SalesOrderHeaderV2);

                SalesOrderHeaderV2.URL = salesURL;

                context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

                sw.Stop();


                StreamWriter stream = File.AppendText(filePath);

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
                stream.Flush();
                stream.Close();
            }

        }

        public static void updateWithCompoundEntityMaximum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string SalesOrderNumber)
        {
            Stopwatch sw = new Stopwatch();

            var SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();
            if (SalesOrderHeaderV2.SalesOrderNumber != null)
            {
                DataServiceCollection<SalesOrderHeaderV2> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2>(context);
                string salesURL = SalesOrderHeaderV2.URL;
                string customerReference = SalesOrderHeaderV2.CustomersOrderReference;
                string DeliveryAddressName = SalesOrderHeaderV2.DeliveryAddressName;
                string DeliveryAddressDescription = SalesOrderHeaderV2.DeliveryAddressDescription;
                string SalesorderName = SalesOrderHeaderV2.SalesOrderName;

                // replace whatever is there with this trash
                salesURL = "http://www." + Guid.NewGuid().ToString() + ".com";
                customerReference = Guid.NewGuid().ToString();
                DeliveryAddressName = Guid.NewGuid().ToString();
                DeliveryAddressDescription = Guid.NewGuid().ToString();
                SalesorderName = Guid.NewGuid().ToString();


                sw.Start();
                SalesOrderCollection.Add(SalesOrderHeaderV2);

                SalesOrderHeaderV2.URL = salesURL;
                SalesOrderHeaderV2.CustomersOrderReference = customerReference;
                SalesOrderHeaderV2.DeliveryAddressName = DeliveryAddressName;
                SalesOrderHeaderV2.DeliveryAddressDescription = DeliveryAddressDescription;
                SalesOrderHeaderV2.SalesOrderName = SalesorderName;


                context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

                sw.Stop();


                StreamWriter stream = File.AppendText(filePath);

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
                stream.Flush();
                stream.Close();
            }
        }

        public static void updateWithSimpleEntityMinimum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string SalesOrderNumber)
        {
            Stopwatch sw = new Stopwatch();

            var SalesOrderHeadersV2EntityOnlySalesTable = context.SalesOrderHeadersV2EntityOnlySalesTable.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();
            if (SalesOrderHeadersV2EntityOnlySalesTable.SalesOrderNumber != null)
            {
                DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable>(context);
                string salesURL = SalesOrderHeadersV2EntityOnlySalesTable.URL;

                // replace whatever is there with this trash
                salesURL = "http://www." + Guid.NewGuid().ToString() + ".com";

                sw.Start();
                SalesOrderCollection.Add(SalesOrderHeadersV2EntityOnlySalesTable);

                SalesOrderHeadersV2EntityOnlySalesTable.URL = salesURL;

                context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

                sw.Stop();


                StreamWriter stream = File.AppendText(filePath);

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
                stream.Flush();
                stream.Close();
            }

        }

        public static void updateWithSimpleEntityMaximum(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string SalesOrderNumber)
        {
            Stopwatch sw = new Stopwatch();

            var SalesOrderHeadersV2EntityOnlySalesTable = context.SalesOrderHeadersV2EntityOnlySalesTable.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();
            if (SalesOrderHeadersV2EntityOnlySalesTable.SalesOrderNumber != null)
            {
                DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable>(context);
                string salesURL = SalesOrderHeadersV2EntityOnlySalesTable.URL;
                string customerReference = SalesOrderHeadersV2EntityOnlySalesTable.CustomersOrderReference;
                string DeliveryAddressName = SalesOrderHeadersV2EntityOnlySalesTable.DeliveryAddressName;
                //string DeliveryAddressDescription = SalesOrderHeadersV2EntityOnlySalesTable.DeliveryAddressDescription;
                string SalesorderName = SalesOrderHeadersV2EntityOnlySalesTable.SalesOrderName;

                // replace whatever is there with this trash
                salesURL = "http://www." + Guid.NewGuid().ToString() + ".com";
                customerReference = Guid.NewGuid().ToString();
                DeliveryAddressName = Guid.NewGuid().ToString();
                //DeliveryAddressDescription = Guid.NewGuid().ToString();
                SalesorderName = Guid.NewGuid().ToString();


                sw.Start();
                SalesOrderCollection.Add(SalesOrderHeadersV2EntityOnlySalesTable);

                SalesOrderHeadersV2EntityOnlySalesTable.URL = salesURL;
                SalesOrderHeadersV2EntityOnlySalesTable.CustomersOrderReference = customerReference;
                SalesOrderHeadersV2EntityOnlySalesTable.DeliveryAddressName = DeliveryAddressName;
                //SalesOrderHeadersV2EntityOnlySalesTable.DeliveryAddressDescription = DeliveryAddressDescription;
                SalesOrderHeadersV2EntityOnlySalesTable.SalesOrderName = SalesorderName;


                context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

                sw.Stop();
                StreamWriter stream = File.AppendText(filePath);

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
                stream.Flush();
                stream.Close();

            }
        }

        public static void createAndDeleteWithSimpleEntity(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();
            string SalesOrderNumber;

            DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable>(context);

            SalesOrderHeaderV2EntityOnlySalesTable SalesOrderHeaderV2EntityOnlySalesTable = new SalesOrderHeaderV2EntityOnlySalesTable();

            SalesOrderCollection.Add(SalesOrderHeaderV2EntityOnlySalesTable);

            //Required Fields
            SalesOrderHeaderV2EntityOnlySalesTable.OrderingCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.InvoiceCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.dataAreaId = DataAreaId;
            SalesOrderHeaderV2EntityOnlySalesTable.CurrencyCode = "USD";
            SalesOrderHeaderV2EntityOnlySalesTable.LanguageId = "en-us";

            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);
            SalesOrderNumber = SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderNumber;
            SalesOrderHeaderV2EntityOnlySalesTable = null;

            sw.Start();
            
            var SalesOrderHeadersV2EntityOnlySalesTable = context.SalesOrderHeadersV2EntityOnlySalesTable.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();


            context.DeleteObject(SalesOrderHeadersV2EntityOnlySalesTable);
            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created and Deleted Sales Order " + SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }

        public static void createAndDeleteWithCompoundEntity(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();
            string SalesOrderNumber;

            DataServiceCollection<SalesOrderHeaderV2> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2>(context);
            SalesOrderHeaderV2 salesOrderHeaderV2 = new SalesOrderHeaderV2();

            SalesOrderCollection.Add(salesOrderHeaderV2);

            // Required Fields
            salesOrderHeaderV2.OrderingCustomerAccountNumber = customerAccount;
            salesOrderHeaderV2.InvoiceCustomerAccountNumber = customerAccount;
            salesOrderHeaderV2.dataAreaId = DataAreaId;
            salesOrderHeaderV2.CurrencyCode = "USD";
            salesOrderHeaderV2.LanguageId = "en-us";

            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);
            SalesOrderNumber = salesOrderHeaderV2.SalesOrderNumber;

            salesOrderHeaderV2 = null;
            sw.Start();

            salesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();


            context.DeleteObject(salesOrderHeaderV2);
            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created and Deleted Sales Order " + SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }

        public static void createAndDeleteWithSingleEntity(Resources context,
                                                           string filePath,
                                                           TestType testType,
                                                           TestWorkload testWorkload,
                                                           string DataAreaId,
                                                           string customerAccount)
        {
            Stopwatch sw = new Stopwatch();
            string SalesOrderNumber;

            DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable> SalesOrderCollection = new DataServiceCollection<SalesOrderHeaderV2EntityOnlySalesTable>(context);

            SalesOrderHeaderV2EntityOnlySalesTable SalesOrderHeaderV2EntityOnlySalesTable = new SalesOrderHeaderV2EntityOnlySalesTable();

            SalesOrderCollection.Add(SalesOrderHeaderV2EntityOnlySalesTable);

            //Required Fields
            SalesOrderHeaderV2EntityOnlySalesTable.OrderingCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.InvoiceCustomerAccountNumber = customerAccount;
            SalesOrderHeaderV2EntityOnlySalesTable.dataAreaId = DataAreaId;
            SalesOrderHeaderV2EntityOnlySalesTable.CurrencyCode = "USD";
            SalesOrderHeaderV2EntityOnlySalesTable.LanguageId = "en-us";

            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);
            SalesOrderNumber = SalesOrderHeaderV2EntityOnlySalesTable.SalesOrderNumber;
            SalesOrderHeaderV2EntityOnlySalesTable = null;

            

            
            sw.Start();

            var AAXSalesOrderHeaderV2EntityOnlySalesOrderNumbers = context.AAXSalesOrderHeaderV2EntityOnlySalesOrderNumbers.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();


            context.DeleteObject(AAXSalesOrderHeaderV2EntityOnlySalesOrderNumbers);
            context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            sw.Stop();

            Console.WriteLine("Created and Deleted Sales Order " + SalesOrderNumber);

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();
        }
    }
}
