﻿using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class LocationlInfoTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [TestMethod]
        public void LocationAdress()
        {
            StringAssert.Matches(LocationInfo.Adress, new Regex(@"\w+"));
        }

        [TestMethod]
        public void LocationEp2Id()
        {
            StringAssert.Matches(LocationInfo.Ep2Id, new Regex(@"\w{8}\d{7}"));
        }

        [TestMethod]
        public void LocationName()
        {
            StringAssert.Matches(LocationInfo.CompanyName, new Regex(@"\w+"));
        }
    }
}