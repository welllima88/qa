using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditTest
    {
        private static PersonEdit _personEdit;
        private static PersonView _personView;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static FormAlert _formAlert;
        private static ContactMenu _contactMenu;
        private static MenusTest _menusTests;
        private static LobbyView _lobby;
        private readonly string _contactId;
        private long _dt;
        private List<string> _formAlerts;

        public ContactEditTest(string contactId)
        {
            _contactId = contactId;
        }

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _contactMenu = new ContactMenu();
            _personEdit = new PersonEdit();
            _personView = new PersonView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();
            _formAlert = new FormAlert();
            _menusTests = new MenusTest();
            _lobby = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Person/PersonEdit.aspx?PageMode=view&PersonId=" + _contactId);
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestMethod]
        public void CheckEditContactMenu()
        {
            _menusTests.ContactMenuCheck(_contactMenu);
            _contactMenu.ContactEdit.Click();
            _menusTests.ContactMenuCheck(_contactMenu);
            _personEdit.CancelButton.Click();
            _menusTests.ContactMenuCheck(_contactMenu);
        }

        [TestMethod]
        public void EditContactAndCancel()
        {
            string salutation = _personView.Salutation;
            string firstName = _personView.FirstName;
            string name = _personView.Name;
            string language = _personView.Language;

            string telephone = _personView.Telephone;
            string mobile = _personView.Mobile;
            string fax = _personView.Fax;
            string email = _personView.Email;

            string po = _personView.Po;
            string StreetNo = _personView.StreetNo;
            string zip = _personView.Zip;
            string city = _personView.City;

            string region = _personView.Region;
            string country = _personView.Country;

            _menusTests.ContactMenuCheck(_contactMenu);

            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc";
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "City";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.CancelButton.Click();

            _menusTests.ContactMenuCheck(_contactMenu);

            Assert.AreEqual(salutation, _personView.Salutation);
            Assert.AreEqual(firstName, _personView.FirstName);
            Assert.AreEqual(name, _personView.Name);
            Assert.AreEqual(language, _personView.Language);

            Assert.AreEqual(telephone, _personView.Telephone);
            Assert.AreEqual(mobile, _personView.Mobile);
            Assert.AreEqual(fax, _personView.Fax);
            Assert.AreEqual(email, _personView.Email);

            Assert.AreEqual(po, _personView.Po);
            Assert.AreEqual(StreetNo, _personView.StreetNo);
            Assert.AreEqual(zip, _personView.Zip);
            Assert.AreEqual(city, _personView.City);
            Assert.AreEqual(region, _personView.Region);
            Assert.AreEqual(country, _personView.Country);
        }

        [TestMethod]
        public void EditContactWithInvalidDataFailed()
        {
            _menusTests.ContactMenuCheck(_contactMenu);

            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc[]rn$°";
            _personEdit.Name = "Siegmund[]rn$°";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789[]rn$°";
            _personEdit.Mobile = "1234567890[]rn$°";
            _personEdit.Fax = "2345678901[]rn$°";
            _personEdit.Email = "tksyr_contact@six-group.com[]rn$°";

            _personEdit.Po = "Pof[]rn$°";
            _personEdit.StreetNo = "Strasse 1[]rn$°";
            _personEdit.Zip = "[]rn$°";
            _personEdit.City = "City[]rn$°";
            _personEdit.Region = "Reg[]rn$°";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr[]rn$°";

            _personEdit.SaveButton.Click();

            _menusTests.ContactMenuCheck(_contactMenu);

            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "Vorname: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Nachname: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Telefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Mobiltelefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Fax: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Postfach: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Ort: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(_formAlerts, "Email: Dies ist keine gültige E-Email Adresse!");
            CollectionAssert.Contains(_formAlerts, "Zusatz: Ungültige Zeichen gefunden!");
            Assert.AreEqual(12, _formAlerts.Count);
        }

        [TestMethod]
        public void EditContactWithoutFirstNameFailed()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "";
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "City";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            _personEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutNameFailed()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc";
            _personEdit.Name = "";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "City";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            _personEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithIncompleteDataFailed()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "";
            _personEdit.FirstName = "";
            _personEdit.Name = "";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "";
            _personEdit.Mobile = "";
            _personEdit.Fax = "";
            _personEdit.Email = "";

            _personEdit.Po = "";
            _personEdit.StreetNo = "";
            _personEdit.Zip = "";
            _personEdit.City = "";
            _personEdit.Region = "";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "";

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Kundenname: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");

            _personEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutStreetAndNumberFailed()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc";
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "City";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            _personEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutCityFailed()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc";
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
            _personEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutZipFailed()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc";
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "";
            _personEdit.City = "City";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            _personEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactAndSave()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Herr";
            _personEdit.FirstName = "Marc" + _dt;
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Französisch [fr]";

            _personEdit.Telephone = "0123456789";
            _personEdit.Mobile = "1234567890";
            _personEdit.Fax = "2345678901";
            _personEdit.Email = "tksyr_contact@six-group.com";

            _personEdit.Po = "Pof";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "City";
            _personEdit.Region = "Reg";
            _personEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "Addr-Add";

            _personEdit.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Herr", _personView.Salutation);
            Assert.AreEqual("Marc" + _dt, _personView.FirstName);
            Assert.AreEqual("Siegmund", _personView.Name);
            Assert.AreEqual("French", _personView.Language);

            Assert.AreEqual("0123456789", _personView.Telephone);
            Assert.AreEqual("1234567890", _personView.Mobile);
            Assert.AreEqual("2345678901", _personView.Fax);
            Assert.AreEqual("tksyr_contact@six-group.com", _personView.Email);

            Assert.AreEqual("Pof", _personView.Po);
            Assert.AreEqual("Strasse 1", _personView.StreetNo);
            Assert.AreEqual("2351", _personView.Zip);
            Assert.AreEqual("City", _personView.City);
            Assert.AreEqual("Reg", _personView.Region);
            Assert.AreEqual("Frankreich [FR]", _personView.Country);
        }

        [TestMethod]
        public void EditContactWithMinimalAndSave()
        {
            _contactMenu.ContactEdit.Click();

            _personEdit.Salutation = "Frau";
            _personEdit.FirstName = "Marc" + _dt;
            _personEdit.Name = "Siegmund";
            _personEdit.Language = "Italienisch [it]";

            _personEdit.Telephone = "";
            _personEdit.Mobile = "";
            _personEdit.Fax = "";
            _personEdit.Email = "";

            _personEdit.Po = "";
            _personEdit.StreetNo = "Strasse 1";
            _personEdit.Zip = "2351";
            _personEdit.City = "City";
            _personEdit.Region = "";
            _personEdit.Country = "Italien [IT]";

            StringAssert.Matches(_personEdit.CreateDate, TestRegExpPatterns.DateTime);

            _personEdit.AdressAddition = "";

            _personEdit.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Frau", _personView.Salutation);
            Assert.AreEqual("Marc" + _dt, _personView.FirstName);
            Assert.AreEqual("Siegmund", _personView.Name);
            Assert.AreEqual("Italienisch [it]", _personView.Language);

            Assert.AreEqual("", _personView.Telephone);
            Assert.AreEqual("", _personView.Mobile);
            Assert.AreEqual("", _personView.Fax);
            Assert.AreEqual("", _personView.Email);

            Assert.AreEqual("", _personView.Po);
            Assert.AreEqual("Strasse 1", _personView.StreetNo);
            Assert.AreEqual("2351", _personView.Zip);
            Assert.AreEqual("City", _personView.City);
            Assert.AreEqual("", _personView.Region);
            Assert.AreEqual("Italien [IT]", _personView.Country);
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