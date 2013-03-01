using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact
{
    [TestClass]
    public class ContactEditTest
    {
        private static ContactEdit _contactEdit;
        private static ContactView _contactView;
        private static IWebDriver _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static ContactMenu _contactMenu;
        private static MenusTest _menusTests;
        private static Lobby _lobby;
        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _contactMenu = new ContactMenu(_driver);
            _contactEdit = new ContactEdit(_driver);
            _contactView = new ContactView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _menusTests = new MenusTest();
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Person/PersonEdit.aspx?PageMode=view&PersonId=8935";
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
        public void CheckEditContactMenu()
        {
            _menusTests.ContactMenuCheck(_contactMenu);
            _contactMenu.ContactEdit.Click();
            _menusTests.ContactMenuCheck(_contactMenu);
            _contactEdit.CancelButton.Click();
            _menusTests.ContactMenuCheck(_contactMenu);
        }

        [TestMethod]
        public void EditContactAndCancel()
        {
            string salutation = _contactView.Salutation;
            string firstName = _contactView.FirstName;
            string name = _contactView.Name;
            string language = _contactView.Language;

            string telephone = _contactView.Telephone;
            string mobile = _contactView.Mobile;
            string fax = _contactView.Fax;
            string email = _contactView.Email;

            string po = _contactView.Po;
            string street = _contactView.Street;
            string zip = _contactView.Zip;
            string city = _contactView.City;

            string region = _contactView.Region;
            string country = _contactView.Country;

            _menusTests.ContactMenuCheck(_contactMenu);

            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc";
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "City";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.CancelButton.Click();

            _menusTests.ContactMenuCheck(_contactMenu);

            Assert.AreEqual(salutation, _contactView.Salutation);
            Assert.AreEqual(firstName, _contactView.FirstName);
            Assert.AreEqual(name, _contactView.Name);
            Assert.AreEqual(language, _contactView.Language);

            Assert.AreEqual(telephone, _contactView.Telephone);
            Assert.AreEqual(mobile, _contactView.Mobile);
            Assert.AreEqual(fax, _contactView.Fax);
            Assert.AreEqual(email, _contactView.Email);

            Assert.AreEqual(po, _contactView.Po);
            Assert.AreEqual(street, _contactView.Street);
            Assert.AreEqual(zip, _contactView.Zip);
            Assert.AreEqual(city, _contactView.City);
            Assert.AreEqual(region, _contactView.Region);
            Assert.AreEqual(country, _contactView.Country);
        }

        [TestMethod]
        public void EditContactWithInvalidDataFailed()
        {
            _menusTests.ContactMenuCheck(_contactMenu);

            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc[]rn$°";
            _contactEdit.Name = "Siegmund[]rn$°";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789[]rn$°";
            _contactEdit.Mobile = "1234567890[]rn$°";
            _contactEdit.Fax = "2345678901[]rn$°";
            _contactEdit.Email = "tksyr_contact@six-group.com[]rn$°";

            _contactEdit.Po = "Pof[]rn$°";
            _contactEdit.Street = "Strasse 1[]rn$°";
            _contactEdit.Zip = "[]rn$°";
            _contactEdit.City = "City[]rn$°";
            _contactEdit.Region = "Reg[]rn$°";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr[]rn$°";

            _contactEdit.SaveButton.Click();

            _menusTests.ContactMenuCheck(_contactMenu);

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Vorname: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Nachname: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Telefon: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Mobiltelefon: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Fax: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Postfach: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Region (Kurzzeichen): Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Contains("Email: Dies ist keine gültige E-Email Adresse!"));
            Assert.IsTrue(_formAlerts.Contains("Zusatz: Ungültige Zeichen gefunden!"));
            Assert.IsTrue(_formAlerts.Count == 12);
        }

        [TestMethod]
        public void EditContactWithoutFirstNameFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "";
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "City";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            _contactEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutNameFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc";
            _contactEdit.Name = "";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "City";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            _contactEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithIncompleteDataFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "";
            _contactEdit.FirstName = "";
            _contactEdit.Name = "";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "";
            _contactEdit.Mobile = "";
            _contactEdit.Fax = "";
            _contactEdit.Email = "";

            _contactEdit.Po = "";
            _contactEdit.Street = "";
            _contactEdit.Zip = "";
            _contactEdit.City = "";
            _contactEdit.Region = "";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "";

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 5);
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));

            _contactEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutStreetAndNumberFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc";
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "City";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            _contactEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutCityFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc";
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            _contactEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutZipFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc";
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "";
            _contactEdit.City = "City";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            _contactEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactAndSave()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Herr";
            _contactEdit.FirstName = "Marc" + _dt;
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Französisch [fr]";

            _contactEdit.Telephone = "0123456789";
            _contactEdit.Mobile = "1234567890";
            _contactEdit.Fax = "2345678901";
            _contactEdit.Email = "tksyr_contact@six-group.com";

            _contactEdit.Po = "Pof";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "City";
            _contactEdit.Region = "Reg";
            _contactEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "Addr-Add";

            _contactEdit.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Herr", _contactView.Salutation);
            Assert.AreEqual("Marc" + _dt, _contactView.FirstName);
            Assert.AreEqual("Siegmund", _contactView.Name);
            Assert.AreEqual("French", _contactView.Language);

            Assert.AreEqual("0123456789", _contactView.Telephone);
            Assert.AreEqual("1234567890", _contactView.Mobile);
            Assert.AreEqual("2345678901", _contactView.Fax);
            Assert.AreEqual("tksyr_contact@six-group.com", _contactView.Email);

            Assert.AreEqual("Pof", _contactView.Po);
            Assert.AreEqual("Strasse 1", _contactView.Street);
            Assert.AreEqual("2351", _contactView.Zip);
            Assert.AreEqual("City", _contactView.City);
            Assert.AreEqual("Reg", _contactView.Region);
            Assert.AreEqual("Frankreich [FR]", _contactView.Country);
        }

        [TestMethod]
        public void EditContactWithMinimalAndSave()
        {
            _contactMenu.ContactEdit.Click();

            _contactEdit.Salutation = "Frau";
            _contactEdit.FirstName = "Marc" + _dt;
            _contactEdit.Name = "Siegmund";
            _contactEdit.Language = "Italienisch [it]";

            _contactEdit.Telephone = "";
            _contactEdit.Mobile = "";
            _contactEdit.Fax = "";
            _contactEdit.Email = "";

            _contactEdit.Po = "";
            _contactEdit.Street = "Strasse 1";
            _contactEdit.Zip = "2351";
            _contactEdit.City = "City";
            _contactEdit.Region = "";
            _contactEdit.Country = "Italien [IT]";

            StringAssert.Matches(_contactEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactEdit.Addition = "";

            _contactEdit.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Frau", _contactView.Salutation);
            Assert.AreEqual("Marc" + _dt, _contactView.FirstName);
            Assert.AreEqual("Siegmund", _contactView.Name);
            Assert.AreEqual("Italienisch [it]", _contactView.Language);

            Assert.AreEqual("", _contactView.Telephone);
            Assert.AreEqual("", _contactView.Mobile);
            Assert.AreEqual("", _contactView.Fax);
            Assert.AreEqual("", _contactView.Email);

            Assert.AreEqual("", _contactView.Po);
            Assert.AreEqual("Strasse 1", _contactView.Street);
            Assert.AreEqual("2351", _contactView.Zip);
            Assert.AreEqual("City", _contactView.City);
            Assert.AreEqual("", _contactView.Region);
            Assert.AreEqual("Italien [IT]", _contactView.Country);
        }

        [TestMethod]
        public void EditContactCheckNavBar()
        {
            Assert.AreEqual("Kontakt", _navigationBar.Current.Text);
            _contactMenu.ContactEdit.Click();
            Assert.AreEqual("Kontakt", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void EditContactCheckHeadline()
        {
            Assert.AreEqual("Kontakt", _lobby.Headline.Text);
            _contactMenu.ContactEdit.Click();
            Assert.AreEqual("Kontakt bearbeiten", _lobby.Headline.Text);
        }
    }
}