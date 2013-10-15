using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditTest
    {
        private readonly string _contactId;
        private double _dt;

        public ContactEditTest(string contactId)
        {
            _contactId = contactId;
        }

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("/Pages/Person/ContactPersonEdit.aspx?PageMode=view&PersonId=" + _contactId);
            _dt = TestLauncher.GenerateTestId();
        }

        [TestMethod]
        public void CheckEditContactMenu()
        {
            MenusTest.ContactMenuCheck();
            ContactMenu.ContactEdit.Click();
            MenusTest.ContactMenuCheck();
            ContactPersonEdit.CancelButton.Click();
            MenusTest.ContactMenuCheck();
        }

        [TestMethod]
        public void EditContactAndCancel()
        {
            string salutation = ContactPersonView.Salutation;
            string firstName = ContactPersonView.FirstName;
            string name = ContactPersonView.Name;
            string language = ContactPersonView.Language;

            string telephone = ContactPersonView.Telephone;
            string mobile = ContactPersonView.Mobile;
            string fax = ContactPersonView.Fax;
            string email = ContactPersonView.Email;

            string po = ContactPersonView.Po;
            string streetNo = ContactPersonView.StreetNo;
            string zip = ContactPersonView.Zip;
            string city = ContactPersonView.City;

            string region = ContactPersonView.Region;
            string country = ContactPersonView.Country;

            MenusTest.ContactMenuCheck();

            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc";
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.CancelButton.Click();

            MenusTest.ContactMenuCheck();

            Assert.AreEqual(salutation, ContactPersonView.Salutation);
            Assert.AreEqual(firstName, ContactPersonView.FirstName);
            Assert.AreEqual(name, ContactPersonView.Name);
            Assert.AreEqual(language, ContactPersonView.Language);

            Assert.AreEqual(telephone, ContactPersonView.Telephone);
            Assert.AreEqual(mobile, ContactPersonView.Mobile);
            Assert.AreEqual(fax, ContactPersonView.Fax);
            Assert.AreEqual(email, ContactPersonView.Email);

            Assert.AreEqual(po, ContactPersonView.Po);
            Assert.AreEqual(streetNo, ContactPersonView.StreetNo);
            Assert.AreEqual(zip, ContactPersonView.Zip);
            Assert.AreEqual(city, ContactPersonView.City);
            Assert.AreEqual(region, ContactPersonView.Region);
            Assert.AreEqual(country, ContactPersonView.Country);
        }

        [TestMethod]
        public void EditContactWithInvalidDataFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc[]rn$°";
            ContactPersonEdit.Name = "Siegmund[]rn$°";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789[]rn$°";
            ContactPersonEdit.Mobile = "1234567890[]rn$°";
            ContactPersonEdit.Fax = "2345678901[]rn$°";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com[]rn$°";

            ContactPersonEdit.Po = "Pof[]rn$°";
            ContactPersonEdit.StreetNo = "Strasse 1[]rn$°";
            ContactPersonEdit.Zip = "[]rn$°";
            ContactPersonEdit.City = "City[]rn$°";
            ContactPersonEdit.Region = "Reg[]rn$°";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr[]rn$°";

            ContactPersonEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "Vorname: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Nachname: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Telefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mobiltelefon: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Fax: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Postfach: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Region (Kurzzeichen): Ungültige Zeichen gefunden!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Email: Dies ist keine gültige E-Email Adresse!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Zusatz: Ungültige Zeichen gefunden!");
            Assert.AreEqual(12, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void EditContactWithoutFirstNameFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "";
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutNameFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc";
            ContactPersonEdit.Name = "";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithIncompleteDataFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "";
            ContactPersonEdit.FirstName = "";
            ContactPersonEdit.Name = "";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "";
            ContactPersonEdit.Mobile = "";
            ContactPersonEdit.Fax = "";
            ContactPersonEdit.Email = "";

            ContactPersonEdit.Po = "";
            ContactPersonEdit.StreetNo = "";
            ContactPersonEdit.Zip = "";
            ContactPersonEdit.City = "";
            ContactPersonEdit.Region = "";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "";

            ContactPersonEdit.SaveButton.Click();

            ContactPersonEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");

            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutStreetAndNumberFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc";
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutCityFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc";
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactWithoutZipFailed()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc";
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.SaveButton.Click();

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            ContactPersonEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditContactAndSave()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = "Marc" + _dt;
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Französisch [fr]";

            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";

            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "Frankreich [FR]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "Addr-Add";

            ContactPersonEdit.SaveButton.Click();
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual("Herr", ContactPersonView.Salutation);
            Assert.AreEqual("Marc" + _dt, ContactPersonView.FirstName);
            Assert.AreEqual("Siegmund", ContactPersonView.Name);
            Assert.AreEqual("French", ContactPersonView.Language);

            Assert.AreEqual("0123456789", ContactPersonView.Telephone);
            Assert.AreEqual("1234567890", ContactPersonView.Mobile);
            Assert.AreEqual("2345678901", ContactPersonView.Fax);
            Assert.AreEqual("tksyr_contact@six-group.com", ContactPersonView.Email);

            Assert.AreEqual("Pof", ContactPersonView.Po);
            Assert.AreEqual("Strasse 1", ContactPersonView.StreetNo);
            Assert.AreEqual("2351", ContactPersonView.Zip);
            Assert.AreEqual("City", ContactPersonView.City);
            Assert.AreEqual("Reg", ContactPersonView.Region);
            Assert.AreEqual("Frankreich [FR]", ContactPersonView.Country);
        }

        [TestMethod]
        public void EditContactWithMinimalAndSave()
        {
            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "Frau";
            ContactPersonEdit.FirstName = "Marc" + _dt;
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "Italienisch [it]";

            ContactPersonEdit.Telephone = "";
            ContactPersonEdit.Mobile = "";
            ContactPersonEdit.Fax = "";
            ContactPersonEdit.Email = "";

            ContactPersonEdit.Po = "";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "";
            ContactPersonEdit.Country = "Italien [IT]";

            StringAssert.Matches(ContactPersonEdit.CreateDate, TestRegExpPatterns.DateTime);

            ContactPersonEdit.AdressAddition = "";

            ContactPersonEdit.SaveButton.Click();
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual("Frau", ContactPersonView.Salutation);
            Assert.AreEqual("Marc" + _dt, ContactPersonView.FirstName);
            Assert.AreEqual("Siegmund", ContactPersonView.Name);
            Assert.AreEqual("Italienisch [it]", ContactPersonView.Language);

            Assert.AreEqual("", ContactPersonView.Telephone);
            Assert.AreEqual("", ContactPersonView.Mobile);
            Assert.AreEqual("", ContactPersonView.Fax);
            Assert.AreEqual("", ContactPersonView.Email);

            Assert.AreEqual("", ContactPersonView.Po);
            Assert.AreEqual("Strasse 1", ContactPersonView.StreetNo);
            Assert.AreEqual("2351", ContactPersonView.Zip);
            Assert.AreEqual("City", ContactPersonView.City);
            Assert.AreEqual("", ContactPersonView.Region);
            Assert.AreEqual("Italien [IT]", ContactPersonView.Country);
        }

        [TestMethod]
        public void EditContactCheckNavBar()
        {
            Assert.AreEqual("Kontakt", NavigationBar.Current.Text);
            ContactMenu.ContactEdit.Click();
            Assert.AreEqual("Kontakt", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void EditContactCheckHeadline()
        {
            Assert.AreEqual("Kontakt", LobbyView.Headline.Text);
            ContactMenu.ContactEdit.Click();
            Assert.AreEqual("Kontakt bearbeiten", LobbyView.Headline.Text);
        }
    }
}