using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Person;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditTest
    {
        private static ContactPersonEdit _contactPersonEdit;
        private static ContactPersonView _contactPersonView;
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
            _contactPersonEdit = new ContactPersonEdit();
            _contactPersonView = new ContactPersonView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();
            _formAlert = new FormAlert();
            _menusTests = new MenusTest();
            _lobby = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Person/ContactPersonEdit.aspx?PageMode=view&PersonId=" + _contactId);
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestMethod]
        public void CheckEditContactMenu()
        {
            _menusTests.ContactMenuCheck(_contactMenu);
            _contactMenu.ContactEdit.Click();
            _menusTests.ContactMenuCheck(_contactMenu);
            _contactPersonEdit.CancelButton.Click();
            _menusTests.ContactMenuCheck(_contactMenu);
        }

        [TestMethod]
        public void EditContactAndCancel()
        {
            string salutation = _contactPersonView.Salutation;
            string firstName = _contactPersonView.FirstName;
            string name = _contactPersonView.Name;
            string language = _contactPersonView.Language;

            string telephone = _contactPersonView.Telephone;
            string mobile = _contactPersonView.Mobile;
            string fax = _contactPersonView.Fax;
            string email = _contactPersonView.Email;

            string po = _contactPersonView.Po;
            string streetNo = _contactPersonView.StreetNo;
            string zip = _contactPersonView.Zip;
            string city = _contactPersonView.City;

            string region = _contactPersonView.Region;
            string country = _contactPersonView.Country;

            _menusTests.ContactMenuCheck(_contactMenu);

            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc";
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.CancelButton.Click();

            _menusTests.ContactMenuCheck(_contactMenu);

            Assert.AreEqual(salutation, _contactPersonView.Salutation);
            Assert.AreEqual(firstName, _contactPersonView.FirstName);
            Assert.AreEqual(name, _contactPersonView.Name);
            Assert.AreEqual(language, _contactPersonView.Language);

            Assert.AreEqual(telephone, _contactPersonView.Telephone);
            Assert.AreEqual(mobile, _contactPersonView.Mobile);
            Assert.AreEqual(fax, _contactPersonView.Fax);
            Assert.AreEqual(email, _contactPersonView.Email);

            Assert.AreEqual(po, _contactPersonView.Po);
            Assert.AreEqual(streetNo, _contactPersonView.StreetNo);
            Assert.AreEqual(zip, _contactPersonView.Zip);
            Assert.AreEqual(city, _contactPersonView.City);
            Assert.AreEqual(region, _contactPersonView.Region);
            Assert.AreEqual(country, _contactPersonView.Country);
        }

        [TestMethod]
        public void EditContactWithInvalidDataFailed()
        {
            _menusTests.ContactMenuCheck(_contactMenu);

            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc[]rn$°";
            _contactPersonEdit.Name = "Siegmund[]rn$°";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789[]rn$°";
            _contactPersonEdit.Mobile = "1234567890[]rn$°";
            _contactPersonEdit.Fax = "2345678901[]rn$°";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com[]rn$°";

            _contactPersonEdit.Po = "Pof[]rn$°";
            _contactPersonEdit.StreetNo = "Strasse 1[]rn$°";
            _contactPersonEdit.Zip = "[]rn$°";
            _contactPersonEdit.City = "City[]rn$°";
            _contactPersonEdit.Region = "Reg[]rn$°";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr[]rn$°";

            _contactPersonEdit.SaveButton.Click();

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

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "";
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            _contactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutNameFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc";
            _contactPersonEdit.Name = "";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            _contactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithIncompleteDataFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "";
            _contactPersonEdit.FirstName = "";
            _contactPersonEdit.Name = "";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "";
            _contactPersonEdit.Mobile = "";
            _contactPersonEdit.Fax = "";
            _contactPersonEdit.Email = "";

            _contactPersonEdit.Po = "";
            _contactPersonEdit.StreetNo = "";
            _contactPersonEdit.Zip = "";
            _contactPersonEdit.City = "";
            _contactPersonEdit.Region = "";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "";

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Kundenname: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");

            _contactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutStreetAndNumberFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc";
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            _contactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutCityFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc";
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
            _contactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutZipFailed()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc";
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            _contactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactAndSave()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Herr";
            _contactPersonEdit.FirstName = "Marc" + _dt;
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Französisch [fr]";

            _contactPersonEdit.Telephone = "0123456789";
            _contactPersonEdit.Mobile = "1234567890";
            _contactPersonEdit.Fax = "2345678901";
            _contactPersonEdit.Email = "tksyr_contact@six-group.com";

            _contactPersonEdit.Po = "Pof";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "Reg";
            _contactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "Addr-Add";

            _contactPersonEdit.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Herr", _contactPersonView.Salutation);
            Assert.AreEqual("Marc" + _dt, _contactPersonView.FirstName);
            Assert.AreEqual("Siegmund", _contactPersonView.Name);
            Assert.AreEqual("French", _contactPersonView.Language);

            Assert.AreEqual("0123456789", _contactPersonView.Telephone);
            Assert.AreEqual("1234567890", _contactPersonView.Mobile);
            Assert.AreEqual("2345678901", _contactPersonView.Fax);
            Assert.AreEqual("tksyr_contact@six-group.com", _contactPersonView.Email);

            Assert.AreEqual("Pof", _contactPersonView.Po);
            Assert.AreEqual("Strasse 1", _contactPersonView.StreetNo);
            Assert.AreEqual("2351", _contactPersonView.Zip);
            Assert.AreEqual("City", _contactPersonView.City);
            Assert.AreEqual("Reg", _contactPersonView.Region);
            Assert.AreEqual("Frankreich [FR]", _contactPersonView.Country);
        }

        [TestMethod]
        public void EditContactWithMinimalAndSave()
        {
            _contactMenu.ContactEdit.Click();

            _contactPersonEdit.Salutation = "Frau";
            _contactPersonEdit.FirstName = "Marc" + _dt;
            _contactPersonEdit.Name = "Siegmund";
            _contactPersonEdit.Language = "Italienisch [it]";

            _contactPersonEdit.Telephone = "";
            _contactPersonEdit.Mobile = "";
            _contactPersonEdit.Fax = "";
            _contactPersonEdit.Email = "";

            _contactPersonEdit.Po = "";
            _contactPersonEdit.StreetNo = "Strasse 1";
            _contactPersonEdit.Zip = "2351";
            _contactPersonEdit.City = "City";
            _contactPersonEdit.Region = "";
            _contactPersonEdit.Country = "Italien [IT]";

            StringAssert.Matches(_contactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            _contactPersonEdit.AdressAddition = "";

            _contactPersonEdit.SaveButton.Click();
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Frau", _contactPersonView.Salutation);
            Assert.AreEqual("Marc" + _dt, _contactPersonView.FirstName);
            Assert.AreEqual("Siegmund", _contactPersonView.Name);
            Assert.AreEqual("Italienisch [it]", _contactPersonView.Language);

            Assert.AreEqual("", _contactPersonView.Telephone);
            Assert.AreEqual("", _contactPersonView.Mobile);
            Assert.AreEqual("", _contactPersonView.Fax);
            Assert.AreEqual("", _contactPersonView.Email);

            Assert.AreEqual("", _contactPersonView.Po);
            Assert.AreEqual("Strasse 1", _contactPersonView.StreetNo);
            Assert.AreEqual("2351", _contactPersonView.Zip);
            Assert.AreEqual("City", _contactPersonView.City);
            Assert.AreEqual("", _contactPersonView.Region);
            Assert.AreEqual("Italien [IT]", _contactPersonView.Country);
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