using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithNoDataTest
    {
        private static CustomerCreate _customerCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private static List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _customerMenu = new CustomerMenu();
            _customerCreate = new CustomerCreate();
            _formAlert = new FormAlert();

            TestLauncher.Navigate("");

            //do test actions already here
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
        }

        [TestMethod]
        public void CustomerNumberOfFormAlerts()
        {
            Assert.AreEqual(7, _formAlerts.Count);
        }

        [TestMethod]
        public void CustomerNameMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "Kundenname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CompanyNameMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void SupplierMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "Mandant: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void StreetNumberMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void ZipMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CityMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CountryMissingFormAlert()
        {
            CollectionAssert.Contains(_formAlerts, "Land: Dies ist ein Pflichtfeld!");
        }
    }
}