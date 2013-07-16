using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithMissingDataTest
    {
        private static CustomerCreate _customerCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerCreate = new CustomerCreate();
            _formAlert = new FormAlert();
            TestLauncher.Navigate("");

            _customerMenu.CustomerCreate.Click();

            // Suggester set once, because not in focus of tests:
        }


        [TestInitialize]
        public void TestInit()
        {
            _customerCreate.CustomerName = "SYR Sele Kunde A";
            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";

            _customerCreate.CompanyName = "SYR Sele Firma A";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";
            _customerCreate.Po = "PFO1";
            _customerCreate.AdressAddition = "Etage 3";
            _customerCreate.Region = "Reg 3";
            _customerCreate.SapNumber = "4440";

            _customerCreate.Agency = "Albert Brun & Partner";

            _customerCreate.Email = "marc.siegmund@six-group.com";
            _customerCreate.Telephone = "0031 58 399 6237";
            _customerCreate.Mobile = "0032 58 399 6237";
            _customerCreate.Fax = "0033 58 399 6237";
            _customerCreate.Web = "www.six-group.com/de-intern";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
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
        public void CreateCustomerWithoutCustomerNameFailed()
        {
            _customerCreate.CustomerName = "";
            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutCompanyNameFailed()
        {
            _customerCreate.CompanyName = "";
            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutStreetAndNumberFailed()
        {
            _customerCreate.StreetName = "";
            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutCityFailed()
        {
            _customerCreate.City = "";
            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateCustomerWithoutZipFailed()
        {
            _customerCreate.Zip = "";
            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }


        [TestMethod]
        public void CreateCustomerWithoutMandantFailed()
        {
            _customerCreate.Supplier = "";
            _customerCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            // Removed: thx to suggester: Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Mandant: Dies ist ein Pflichtfeld!"));
        }
    }
}