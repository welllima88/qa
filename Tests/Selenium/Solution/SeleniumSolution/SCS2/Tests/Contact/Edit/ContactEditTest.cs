using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditTest
    {
        private static string _contactId;
        private static string _firstName;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);

            Edit();
        }

        public static void Edit()
        {
            ContactMenu.ContactEdit.Click();
            _firstName = "Marc" + TestLauncher.GenerateTestId();
            ContactPersonEdit.Salutation = "Herr";
            ContactPersonEdit.FirstName = _firstName;
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "fr";
            ContactPersonEdit.Telephone = "0123456789";
            ContactPersonEdit.Mobile = "1234567890";
            ContactPersonEdit.Fax = "2345678901";
            ContactPersonEdit.Email = "tksyr_contact@six-group.com";
            ContactPersonEdit.Po = "Pof";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "Reg";
            ContactPersonEdit.Country = "FR";
            ContactPersonEdit.AdressAddition = "Add";
            ContactPersonEdit.Web = "www.six-group.com";

            ContactPersonEdit.SaveButton.Click();
        }

        [TestMethod]
        public void ContactMenuCheck()
        {
            MenusTest.ContactMenuCheck();
        }

        [TestMethod]
        public void Salutation()
        {
            Assert.AreEqual("Herr", ContactPersonView.Salutation);
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("Marc" + _firstName, ContactPersonView.FirstName);
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual("Siegmund", ContactPersonView.Name);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", ContactPersonView.Language);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("0123456789", ContactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("1234567890", ContactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("2345678901", ContactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("tksyr_contact@six-group.com", ContactPersonView.Email);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("Pof", ContactPersonView.Po);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Strasse 1", ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("2351", ContactPersonView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("City", ContactPersonView.City);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("Reg", ContactPersonView.Region);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", ContactPersonView.Country);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("www.six-group.com", ContactPersonView.Web);
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("Add", ContactPersonView.AddressAddition);
        }

        [TestMethod]
        public void MostRecentElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }

        public static void Check()
        {
            Assert.AreEqual("Herr", ContactPersonView.Salutation);
            Assert.AreEqual(_firstName, ContactPersonView.FirstName);
            Assert.AreEqual("Siegmund", ContactPersonView.Name);
            Assert.AreEqual("Französisch [fr]", ContactPersonView.Language);
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
            Assert.AreEqual("www.six-group.com", ContactPersonView.Web);
            Assert.AreEqual("Add", ContactPersonView.AddressAddition);
        }
    }
}