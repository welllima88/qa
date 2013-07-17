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
        private static ContactEdit _contactEdit;
        private static ContactView _contactView;
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
            _contactEdit = new ContactEdit();
            _contactView = new ContactView();
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
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
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
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
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
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Kundenname: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");

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
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
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
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
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
            Assert.AreEqual(1, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
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