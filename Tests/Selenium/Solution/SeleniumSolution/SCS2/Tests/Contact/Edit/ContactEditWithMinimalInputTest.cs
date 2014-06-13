using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestData;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditWithMinimalInputTest
    {
        private static string _contactId;
        private static string _dt;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);
            _dt = Factory.GenerateTestId();

            ContactPersonView.EditButton.Click();

            ContactPersonEdit.Salutation = "";
            ContactPersonEdit.FirstName = "";
            ContactPersonEdit.Name = "SYR" + _dt;
            ContactPersonEdit.Language = "fr";
            ContactPersonEdit.Telephone = "";
            ContactPersonEdit.Mobile = "";
            ContactPersonEdit.Fax = "";
            ContactPersonEdit.Email = "";
            ContactPersonEdit.Po = "";
            ContactPersonEdit.StreetNo = "";
            ContactPersonEdit.Zip = "";
            ContactPersonEdit.City = "";
            ContactPersonEdit.Region = "";
            ContactPersonEdit.Country = "FR";
            ContactPersonEdit.AdressAddition = "";
            ContactPersonEdit.Web = "";

            ContactPersonEdit.SaveButton.Click();
        }

        [TestMethod]
        public void Salutation()
        {
            Assert.AreEqual("", ContactPersonView.Salutation);
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("", ContactPersonView.FirstName);
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual("SYR" + _dt, ContactPersonView.Name);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", ContactPersonView.Language);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("", ContactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", ContactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", ContactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", ContactPersonView.Email);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", ContactPersonView.Po);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("", ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("", ContactPersonView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("", ContactPersonView.City);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", ContactPersonView.Region);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", ContactPersonView.Country);
        }

        [TestMethod]
        [Ignore]
        public void Web()
        {
            Assert.AreEqual("", ContactPersonView.Web);
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", ContactPersonView.AddressAddition);
        }

        [TestMethod]
        public void MostRecentElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}