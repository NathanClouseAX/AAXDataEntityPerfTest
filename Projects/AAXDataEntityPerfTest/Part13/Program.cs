﻿using System;
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

namespace Part13
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part13.txt";



        static void Main(string[] args)
        {
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);
            var context = new Resources(oDataUri);


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

            StreamWriter stream = File.CreateText(filePath);
            stream.WriteLine("Entity, TestType, Workload, Duration");
            stream.Flush();
            stream.Close();

            Console.WriteLine("Connected To " + ClientConfiguration.Default.UriString);

            SalesValues values;

            int loopCount = 100;

            Stopwatch sw = new Stopwatch();

            values = SalesOrderHeaderV2Tester.getRandomNonRetailCombination();


            for (int i = 0; i < loopCount; i++)
            {
                SalesOrderHeaderV2Tester.updateWithSimpleEntityMinimum(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.UpdateSimpleMinimum, values.DataAreaId, values.SalesId);
            }


            for (int i = 0; i < loopCount; i++)
            {
                SalesOrderHeaderV2Tester.updateWithSimpleEntityMaximum(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.UpdateSimpleMaximum, values.DataAreaId, values.SalesId);
            }


            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();

        }
    }
}
