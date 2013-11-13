using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.Support.AddService
{
    /// <summary>
    ///     Just check if csv or excel can be loaded
    /// </summary>
    [TestClass]
    public class CheckExcel
    {
        public static readonly string[] Logins =
            {
                "tkmas",
                "tkake",
                "tkanh",
                "tkanm",
                "tkbdj",
                "tkbet",
                "tkblg",
                "tkblj",
                "tkbsl",
                "tkchd",
                "tkchv",
                "tkcoh",
                "tkdi6",
                "tkdio",
                "tkdnm",
                "tkeni",
                "tkfia",
                "tkghl1",
                "tkgyp",
                "tkhhf",
                "tkhnd",
                "tkhsc",
                "tkhtc",
                "tkjar",
                "tkjuu",
                "tkk6h",
                "tkkne",
                "tklej",
                "tklhb",
                "tklst",
                "tkltg",
                "tkmcr",
                "tkmin",
                "tkmlt",
                "tkmoe",
                "tkmuf",
                "tkonb",
                "tkpas",
                "tkplr",
                "tkpun",
                "tkr34",
                "tkrnn",
                "tkryr",
                "tks09",
                "tksiw",
                "tksln",
                "tksxi",
                "tksyr",
                "tktib",
                "tktrs",
                "tkvot",
                "tkweb",
                "tkwep",
                "tkwsu",
                "tkzas",
                "txb5f",
                "txbmk",
                "txel0",
                "txhi6",
                "txl22",
                "txlul",
                "txmnc",
                "txv5m"
            };

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
//            "C:\\Users\\siegmund\\Desktop\\ProdSystemUsers.csv",
            "C:\\ProdSystemUsers.csv",
            "ProdSystemUsers#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void CheckCsvData()
        {
            string userId = Convert.ToString(TestContext.DataRow[0]);
            Console.Out.WriteLine(userId);
        }

        [DataSource("System.Data.Odbc",
            @"Dsn=Excel Files;dbq=UANA.xls", "L$",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void RemoveAndAdsdAnalyzerToRepairWesState()
        {
            string userId = Convert.ToString(TestContext.DataRow["Login_Id"]);
            Console.Out.WriteLine(userId);
        }

        [DataSource("System.Data.Odbc",
            "Dsn=Excel Files;dbq='C:\\Users\\siegmund\\Desktop\\UANA.xlsx'", "L$",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void RemoveAndAddAnalyzerToRepairWesState()
        {
            string userId = Convert.ToString(TestContext.DataRow["Login_Id"]);
            Console.Out.WriteLine(userId);
        }

        [DataSource("System.Data.Odbc",
            "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xls)};dbq='C:\\Users\\siegmund\\Desktop\\UANA.xlsx';defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true"
            , "Sheet1$", DataAccessMethod.Sequential), TestMethod]
        public void RemovAndAddAnalyzerToRepairWesState()
        {
            string userId = Convert.ToString(TestContext.DataRow["Login_Id"]);
            Console.Out.WriteLine(userId);
        }
    }
}