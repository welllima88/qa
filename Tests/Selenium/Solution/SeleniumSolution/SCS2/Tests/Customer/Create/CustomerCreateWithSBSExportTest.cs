﻿using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithSbsExportTest
    {
        private const int WaitMilliseconds = 1000;
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static CustomerMenu _customerMenu;

        private static long _dt;
        private static string _custId;
        private int _numberOfRetries;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerCreate = new CustomerCreate();
            _customerView = new CustomerView();
            _dt = DateTime.Now.Ticks; //timestamp for each test

            TestLauncher.Navigate("");

            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "CHF";
            _customerCreate.CustomerName = "SYR SBS Kunde" + _dt;

            _customerCreate.CompanyName = "SYR SBS Firma" + _dt;
            _customerCreate.StreetNo = "SbsRoad. 201";
            _customerCreate.Zip = "8008";
            _customerCreate.City = "SBS";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";

            _customerCreate.SaveButton.Click();
            _custId = _customerView.CustomerNumber;
        }

        [TestInitialize]
        public void TestInit()
        {
            Assert.AreEqual("SYR SBS Kunde" + _dt, _customerView.CustomerName);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsDebitorNumberGeneratedFromCustomerId()
        {
            Assert.AreEqual(_custId, _customerView.SbsDebitNumber);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsAdressNumberGeneratedFromSbs()
        {
            _numberOfRetries = 4;
            int retry = _numberOfRetries;
            do
            {
                try
                {
                    StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(WaitMilliseconds);
                    //carefull
                    //_driver.Navigate().Refresh(); doesn't work proper, so this is better:
                    _customerMenu.Customer.Click();
                    retry--;
                }
            } while (retry > 0);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsDebitorNumberCorrectFormat()
        {
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsAdressNumberCorrectFormat()
        {
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }
    }
}