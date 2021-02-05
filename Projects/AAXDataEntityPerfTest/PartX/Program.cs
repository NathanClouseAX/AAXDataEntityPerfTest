using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartX
{
    class Program
    {
        /*
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part8.txt";

        static void CallChildThread(Resources context, ref Logger logger, int threadCount)
        {
            string x = "";
            SalesValues values;
            int loopCount = 100;

            List<String> logs = new List<string>();

            int threadId = Thread.CurrentThread.ManagedThreadId;

            context.BuildingRequest += (sender, e) =>
            {
                var uriBuilder = new UriBuilder(e.RequestUri);
                // Requires a reference to System.Web and .NET 4.6.1+
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


            for (int i = 0; i < loopCount; i++)
            {
                context.Projects.FirstOrDefault().GetProjectTypes();


                //logs.Add(SalesOrderHeaderV2Tester.runOneReadThread(context, threadCount, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.ReadThread, values.SalesId, values.DataAreaId));
            }


            //logger.addList(logs);

        }

        public static void runProjectTest(int threadCount)
        {
            // / | \ - 
            int charCounter = 0;
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);

            Logger logger = new Logger(filePath);

            //Console.WriteLine("Connected To " + ClientConfiguration.Default.UriString);

            Console.WriteLine("Starting Project Tests for Thread Count " + threadCount.ToString() + " at " + DateTime.Now.ToString());

            List<Thread> Threads = new List<Thread>();

            for (int i = 0; i < threadCount; i++)
            {
                Thread childThread = new Thread(() => CallChildThread(new Resources(oDataUri), ref logger, threadCount));
                Threads.Add(childThread);
            }

            foreach (Thread thread in Threads)
            {
                thread.Start();
            }

            //wait for all threads to actually kick off
            Thread.Sleep(5000);

            bool wait = true;

            while (wait)
            {
                wait = false;

                foreach (Thread thread in Threads)
                {
                    if (thread.ThreadState == System.Threading.ThreadState.Running)
                    {
                        wait = true;
                        break;
                    }
                }

                if (wait)
                {
                    Thread.Sleep(5000);
                    charCounter++;
                    if (charCounter > 3)
                    {
                        charCounter = 0;
                    }
                    switch (charCounter)
                    {
                        case 0:
                            Console.Clear();
                            Console.Write("Working \\");
                            break;

                        case 1:
                            Console.Clear();
                            Console.Write("Working |");
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Working /");
                            break;

                        case 3:
                            Console.Clear();
                            Console.Write("Working -");
                            break;

                    }
                }
            }

            logger.saveNow();
        }
        */
        static void Main(string[] args)
        {
            /*
            StreamWriter stream = File.CreateText(filePath);
            stream.WriteLine("Entity,ThreadCount, TestType, Workload, Duration");
            stream.Flush();
            stream.Close();

            runProjectTest(100);
            */

        }
        
    }
        
}
