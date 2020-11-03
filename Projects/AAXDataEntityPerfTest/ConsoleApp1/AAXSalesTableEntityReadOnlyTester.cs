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
    class AAXSalesTableEntityReadOnlyTester : SalesOrderTester
    {
        public static string logTemplate = "";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            AAXSalesTableReadOnly AAXSalesTableReadOnly = context.AAXSalesTablesReadOnly.Where(x => x.SalesId == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine("AAXSalesTableEntityReadOnly," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

 
    }
}
