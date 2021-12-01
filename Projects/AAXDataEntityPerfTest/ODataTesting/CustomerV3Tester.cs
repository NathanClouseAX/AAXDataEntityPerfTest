using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AuthenticationUtility;
using Microsoft.OData.Client;
using Microsoft.Dynamics.DataEntities;

using System.Threading;

using System.Web;
using System.Data;
using System.IO;

using System.Diagnostics;

namespace ODataTesting
{
    public class CustomerV3Tester : CustomerTester
    {
        public static string logTemplate = "{Entity},{testType},{testWorkload},{sw.Elapsed.TotalMilliseconds.ToString()}";
        public static string Entity = "CustCustomerV3";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string CustomerAccount, string DataAreaId)
        {
            int tryCount = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();

            while (true)
            {
                try
                {
                    tryCount++;
                    CustomerV3 CustomerV3 = context.CustomersV3.Where(x => x.CustomerAccount == CustomerAccount && x.dataAreaId == DataAreaId).First();

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

    }
}
