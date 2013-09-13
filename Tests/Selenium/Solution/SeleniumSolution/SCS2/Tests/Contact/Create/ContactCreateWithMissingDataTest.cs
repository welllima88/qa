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
        private static PersonCreate _personCreate;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;

        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _personCreate = new PersonCreate();
            _formAlert = new FormAlert();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _personCreate.Salutation = "Herr";
            _personCreate.FirstName = "Marc";
            _personCreate.Name = "Siegmund SYR AUTO";
            _personCreate.Language = "de";
            _personCreate.Telephone = "+41 58 399 6237 - 1";
            _personCreate.Mobile = "+41 58 399 6237 - 2";
            _personCreate.Fax = "+41 58 399 6237 - 3";
            _personCreate.Email = "contact@six-group.com";
            _personCreate.StreetNo = "Kontakt-Weg 1";
            _personCreate.Po = "POC";
            _personCreate.Zip = "55555";
            _personCreate.City = "Berlin";
            _personCreate.Region = "Mitte";
            _personCreate.Country = "DE";
            _personCreate.AddressAddition = "Zusatz1";
        }

        [TestMethod]
        public void WithoutFirstName()
        {
            _customerMenu.ContactCreate.Click();

            _personCreate.FirstName = "";

            _personCreate.SaveButton.Click();
            _formAlerts = _formAlert.FormAlertList;

            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Vorname: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutLastName()
        {
            _customerMenu.ContactCreate.Click();

            _personCreate.Name = "";

            _personCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Name: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutStreetAndNumber()
        {
            _customerMenu.ContactCreate.Click();

            _personCreate.StreetNo = "";

            _personCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutCityFailed()
        {
            _customerMenu.ContactCreate.Click();

            _personCreate.City = "";

            _personCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void WithoutZipFailed()
        {
            _customerMenu.ContactCreate.Click();

            _personCreate.Zip = "";

            _personCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
        }
    }
}