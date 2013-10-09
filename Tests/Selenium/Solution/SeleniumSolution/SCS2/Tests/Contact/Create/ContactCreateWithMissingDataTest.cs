using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMissingDataTest
    {
        private static ContactPersonCreate _contactPersonCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _contactPersonCreate = new ContactPersonCreate();
            _formAlert = new FormAlert();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.Salutation = "Herr";
            _contactPersonCreate.FirstName = "Marc";
            _contactPersonCreate.Name = "Siegmund SYR AUTO";
            _contactPersonCreate.Language = "de";
            _contactPersonCreate.Telephone = "+41 58 399 6237 - 1";
            _contactPersonCreate.Mobile = "+41 58 399 6237 - 2";
            _contactPersonCreate.Fax = "+41 58 399 6237 - 3";
            _contactPersonCreate.Email = "contact@six-group.com";
            _contactPersonCreate.StreetNo = "Kontakt-Weg 1";
            _contactPersonCreate.Po = "POC";
            _contactPersonCreate.Zip = "55555";
            _contactPersonCreate.City = "Berlin";
            _contactPersonCreate.Region = "Mitte";
            _contactPersonCreate.Country = "DE";
            _contactPersonCreate.AddressAddition = "Zusatz1";
        }

        [TestMethod]
        public void WithoutFirstName()
        {
            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.FirstName = "";

            _contactPersonCreate.SaveButton.Click();
            _formAlerts = _formAlert.FormAlertList;

            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Vorname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutLastName()
        {
            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.Name = "";

            _contactPersonCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Name: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutStreetAndNumber()
        {
            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.StreetNo = "";

            _contactPersonCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutCityFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.City = "";

            _contactPersonCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutZipFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.Zip = "";

            _contactPersonCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}