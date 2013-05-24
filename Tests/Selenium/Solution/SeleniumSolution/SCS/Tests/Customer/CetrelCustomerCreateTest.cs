using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Tests.Customer
{
    [TestClass]
    [Ignore]
    public class CetrelCustomerCreateTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static IWebDriverAdapter _driver;
        private static ScsClassicTestDirector _tb;
        private static CustomerMenu _customerMenu;

        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsClassicTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _customerCreate = new CustomerCreate(_driver);
            _customerView = new CustomerView(_driver);
            _customerMenu = new CustomerMenu(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _dt = DateTime.Now.Ticks; //timestamp for each test
            _formAlerts=new List<string>(0);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateCustomerAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "CETREL S.A.";
            _customerCreate.CustomerName = "SYR Cetrel Kunde Create";
            _customerCreate.CategoryCode = "3663: HOTELES EL PRESIDENTE";
            _customerCreate.SupportContract = "SPA Servicepaket Advance";
            _customerCreate.CustomerSegment = "07_P_CETREL";

            _customerCreate.CompanyName = "SYR Cetrel Firma Create";
            _customerCreate.StreetName = "Luxemburgerli 1a";
            _customerCreate.Zip = "11247";
            _customerCreate.City = "Luxemburg";
            _customerCreate.Po = "LUX1";
            _customerCreate.AdressAddition = "ZusatzLUX";
            _customerCreate.Region = "WestLUX";
            _customerCreate.SapNumber = "9129";

            _customerCreate.Agency = "SIX LUX";
            _customerCreate.Language = "Französisch [fr]";
            _customerCreate.Country = "Luxemburg [LU]";
            _customerCreate.Email = "marc.siegmund@six-group.com/lux";
            _customerCreate.Telephone = "+61 58 399 6237";
            _customerCreate.Mobile = "+62 58 399 6237";
            _customerCreate.Fax = "+63 58 399 6237";
            _customerCreate.Web = "www.six-group.com/cetrel";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("SYR Sele Kunde A", _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual("SYR Cetrel Kunde Create", _customerView.CustomerName);
            Assert.AreEqual("CETREL S.A.", _customerView.Supplier);
            Assert.AreEqual("9129", _customerView.SapNumber);
            Assert.AreEqual("3663: HOTELES EL PRESIDENTE", _customerView.CategoryCode);
            Assert.AreEqual("SPA Servicepaket Advance",
                            _customerView.SupportContract);

            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Cetrel Firma Create", _customerView.CompanyName);
            Assert.AreEqual("LUX1", _customerView.Po);
            Assert.AreEqual("ZusatzLUX", _customerView.AdressAddition);
            Assert.AreEqual("WestLUX", _customerView.Region);
            Assert.AreEqual("Luxemburgerli 1a", _customerView.StreetNo);
            Assert.AreEqual("11247", _customerView.Zip);
            Assert.AreEqual("Luxemburg", _customerView.City);
            Assert.AreEqual("SIX LUX", _customerView.Agency);
            Assert.AreEqual("Französisch [fr]", _customerView.Language);
            Assert.AreEqual("Luxemburg [LU]", _customerView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", _customerView.Email);
            Assert.AreEqual("+61 58 399 6237", _customerView.Telephone);
            Assert.AreEqual("+62 58 399 6237", _customerView.Mobile);
            Assert.AreEqual("+63 58 399 6237", _customerView.Fax);
            Assert.AreEqual("www.six-group.com/cetrel", _customerView.Web);
        }
    }
}