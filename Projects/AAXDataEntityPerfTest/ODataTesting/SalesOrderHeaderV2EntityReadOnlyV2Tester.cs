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
    public class SalesOrderHeaderV2EntityReadOnlyTester : SalesOrderTester
    {
        public static string logTemplate = "";
        public static string Entity = "SalesOrderHeaderV2EntityReadOnly";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            try
            {
                SalesOrderHeaderV2EntityReadOnly SalesOrderHeaderV2EntityReadOnly = context.SalesOrderHeadersV2EntityReadOnly.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();
                sw.Stop();

                StreamWriter stream = File.AppendText(filePath);

                stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
                stream.Flush();
                stream.Close();
            }
            catch
            {
                ;
            }

            

        }

        public static void runReads(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string DataAreaId, string customerAccount, int count)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            context.SalesOrderHeadersV2.Where(x => x.dataAreaId == DataAreaId && x.OrderingCustomerAccountNumber == customerAccount).Take(count).ToList();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);
            stream.WriteLine(Entity + "," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());

            stream.Flush();
            stream.Close();

        }


    }
}
