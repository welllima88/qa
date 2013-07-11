using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMissingDataTest
    {
        private static ContactCreate _contactCreate;
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _customerMenu = new CustomerMenu(_driver);
            _contactCreate = new ContactCreate(_driver);
            _formAlert = new FormAlert(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=401152";

            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "de";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "DE";
            _contactCreate.AddressAddition = "Zusatz1";
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
        public void WithoutFirstName()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.FirstName = "";

            _contactCreate.SaveButton.Click();
            _formAlerts = _formAlert.FormAlertList;

            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Vorname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void WithoutLastName()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Name = "";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Name: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void WithoutStreetAndNumber()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Street = "";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void WithoutCityFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.City = "";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void WithoutZipFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Zip = "";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }
    }
}