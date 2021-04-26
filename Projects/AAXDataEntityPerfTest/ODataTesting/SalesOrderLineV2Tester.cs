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

namespace ODataTesting
{
    public class SalesOrderLineV2Tester : SalesOrderTester
    {
        public static string logTemplate = "";
        public static string Entity = "SalesOrderLineV2";

        public static void runOneExpandedRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            Entity = "SalesOrderLineV2 (W/ Expand)";

            sw.Start();

            SalesOrderLine SalesOrderLine = context.SalesOrderLines.Expand(x => x.SalesOrderHeaderV2).Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);


            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderLine SalesOrderLine = context.SalesOrderLines.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runOneCombinedRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            Entity = "SalesOrderLineV2+SalesOrderHeaderV2";

            sw.Start();

            SalesOrderLine SalesOrderLine = context.SalesOrderLines.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();
            SalesOrderHeaderV2 SalesOrderHeaderV2 = context.SalesOrderHeadersV2.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

        public static void runGetAllPages(Resources context, string filePath, TestType testType, TestWorkload testWorkload)
        {
            Stopwatch sw = new Stopwatch();
            StreamWriter stream = File.AppendText(filePath);
            // DataServiceQueryContinuation<T> contains the next link
            DataServiceQueryContinuation<SalesOrderLine> nextLink = null;

            // Get the first page
            sw.Start();
            var response = context.SalesOrderLines.Execute() as QueryOperationResponse<SalesOrderLine>;

            do
            {

                if (nextLink != null)
                {
                    sw.Start();
                    response = context.Execute<SalesOrderLine>(nextLink) as QueryOperationResponse<SalesOrderLine>;

                    sw.Stop();
                }
                else
                {
                    sw.Stop();
                }

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString()); 

                //forced loop to enumerate each item in the response
                foreach (SalesOrderLine salesLine in response)
                {
                }
            }
            // Loop if there is a next link
            while ((nextLink = response.GetContinuation()) != null);

            stream.Flush();
            stream.Close();
        }

        public static void runGetAllPagesSkipTake(Resources context, string filePath, TestType testType, TestWorkload testWorkload)
        {
            Stopwatch sw = new Stopwatch();
            StreamWriter stream = File.AppendText(filePath);

            int skip = 0;
            int take = 10000;

            //get count of records without getting any other data
            int numberOfRecords = context.SalesOrderLines.Take(0).Count();

            sw.Start();

            for (skip = 0; skip <= numberOfRecords; skip += take)
            {
                sw.Start();
                context.SalesOrderLines.Skip(skip).Take(take).ToList();

                sw.Stop();

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            }

            stream.Flush();
            stream.Close();

        }


    }
}
