﻿using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class CustomerInfoTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [TestMethod]
        public void Adress()
        {
            StringAssert.Matches(CustomerInfo.Adress.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void CustomerId()
        {
            StringAssert.Matches(CustomerInfo.Id.Text, new Regex(@"\d+"));
        }

        [TestMethod]
        public void CustomerName()
        {
            StringAssert.Matches(CustomerInfo.Name.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void CustomerMarks()
        {
            Assert.IsTrue(CustomerInfo.Info.Displayed);
        }
    }
}