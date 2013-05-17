using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class CustomerCreateWithNoDataTest
    {
        private static CustomerCreate _customerCreate;
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _customerMenu = new CustomerMenu(_driver);
            _customerCreate = new CustomerCreate(_driver);
            _formAlert = new FormAlert(_driver);

            //do test actions already here
            _driver.Url = _tb.BaseUrl + "/Default.aspx";
            _customerMenu.CustomerCreate.Click();
            _customerCreate.SaveButton.Click();
            _formAlerts = _formAlert.FormAlertList;
        }

        [TestInitialize]
        public void TestInit()
        {
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
        public void CustomerNumberOfFormAlerts()
        {
            Assert.IsTrue(_formAlerts.Count == 7);
        }

        [TestMethod]
        public void CustomerNameMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CompanyNameMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld! Zu kurze Eingabe!"));
        }

        [TestMethod]
        public void SupplierMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("Mandant: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void StreetNumberMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void ZipMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CityMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }


        [TestMethod]
        public void CountryMissingFormAlert()
        {
            Assert.IsTrue(_formAlerts.Contains("Land: Dies ist ein Pflichtfeld!"));
        }
    }
}