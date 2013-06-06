using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact
{
    [TestClass]
    public class ContactCreateTest
    {
        private static ContactCreate _contactCreate;
        private static ContactView _contactView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;
        private static ContactMenu _contactMenu;
        private static MenusTest _menusTests;
        private static LobbyView _lobby;

        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _customerMenu = new CustomerMenu(_driver);
            _contactCreate = new ContactCreate(_driver);
            _contactView = new ContactView(_driver);
            _contactMenu = new ContactMenu(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _menusTests = new MenusTest();
            _lobby = new LobbyView(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=401152";
            _dt = DateTime.Now.Ticks; //timestamp for each test
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
        public void CreateContactAndCancel()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            //_contactCreate.CancelButton.Click();
        }

        [TestMethod]
        public void CreateContactWithInvalidDataFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Kundennummer: Ihre Eingabe ist ungültig!"));
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Zusatz: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Telefon: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Mobiltelefon: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Fax: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Postfach: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Region (Kurzzeichen): Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Email: Dies ist keine gültige E-Email Adresse!"));
            Assert.IsTrue(_formAlerts.Contains("Web: Dies ist keine gültige Web Adresse!"));
            Assert.IsTrue(_formAlerts.Count == 14);
        }

        [TestMethod]
        public void CreateContactWithIncompleteDataFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 7);
            Assert.IsTrue(_formAlerts.Contains("Vorname: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Nachname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Sprache: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Land: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateContactWithoutContactFirstNameFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Vorname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateContactWithoutCompanyNameFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Name: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateContactWithoutStreetAndNumberFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateContactWithoutCityFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateContactWithoutZipFailed()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }


        [TestMethod]
        public void CreateContactAndSave()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();

            Assert.AreEqual(_contactView.Salutation, "Herr");
            Assert.AreEqual(_contactView.FirstName, "Marc");
            Assert.AreEqual(_contactView.Name, "Siegmund SYR AUTO");
            Assert.AreEqual(_contactView.Language, "Deutsch");
            Assert.AreEqual(_contactView.Telephone, "+41 58 399 6237 - 1");
            Assert.AreEqual(_contactView.Mobile, "+41 58 399 6237 - 2");
            Assert.AreEqual(_contactView.Fax, "+41 58 399 6237 - 3");
            Assert.AreEqual(_contactView.Email, "contact@six-group.com");
            Assert.AreEqual(_contactView.Street, "Kontakt-Weg 1");
            Assert.AreEqual(_contactView.Po, "POC");
            Assert.AreEqual(_contactView.Zip, "55555");
            Assert.AreEqual(_contactView.City, "Berlin");
            Assert.AreEqual(_contactView.Region, "Mitte");
            Assert.AreEqual(_contactView.Country, "Deutschland [DE]");
            Assert.AreEqual(_contactView.AddressAddition, "Zusatz1");
        }

        [TestMethod]
        public void CreateContactWithMinimalAndSave()
        {
            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "Deutsch [de]";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "Deutschland [DE]";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(_contactView.Salutation, "Herr");
            Assert.AreEqual(_contactView.FirstName, "Marc");
            Assert.AreEqual(_contactView.Name, "Siegmund SYR AUTO");
            Assert.AreEqual(_contactView.Language, "Deutsch [de]");
            Assert.AreEqual(_contactView.Telephone, "+41 58 399 6237 - 1");
            Assert.AreEqual(_contactView.Mobile, "+41 58 399 6237 - 2");
            Assert.AreEqual(_contactView.Fax, "+41 58 399 6237 - 3");
            Assert.AreEqual(_contactView.Email, "contact@six-group.com");
            Assert.AreEqual(_contactView.Street, "Kontakt-Weg 1");
            Assert.AreEqual(_contactView.Po, "POC");
            Assert.AreEqual(_contactView.Zip, "55555");
            Assert.AreEqual(_contactView.City, "Berlin");
            Assert.AreEqual(_contactView.Region, "Mitte");
            Assert.AreEqual(_contactView.Country, "Deutschland [DE]");
            Assert.AreEqual(_contactView.AddressAddition, "Zusatz1");
        }

        [TestMethod]
        public void CreateContactCheckNavBar()
        {
            _customerMenu.ContactCreate.Click();
            Assert.AreEqual("Neuer Kontakt", _navigationBar.Current.Text);
        }

        [Ignore]
        [TestMethod]
        public void CreateContactCheckMenu()
        {
            _customerMenu.ContactCreate.Click();
            _menusTests.CustomerMenuCheck(_customerMenu);
            Assert.IsTrue(_contactMenu.Contact.Displayed);
        }

        [Ignore]
        [TestMethod]
        public void CreateContactCheckHeadline()
        {
            _customerMenu.ContactCreate.Click();
            Assert.AreEqual("Neuer Kontakt", _lobby.Headline.Text);
        }
    }
}