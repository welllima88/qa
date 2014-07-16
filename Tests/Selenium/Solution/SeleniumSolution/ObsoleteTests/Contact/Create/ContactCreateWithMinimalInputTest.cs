using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMinimalInputTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.Name = "Siegmund SYR AUTO";

            ContactPersonCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("", ContactPersonView.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", ContactPersonView.Name);
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(ContactPersonView.Language, "[de]");
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
        public void Street()
        {
            Assert.AreEqual("", ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", ContactPersonView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("", ContactPersonView.Zip);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", ContactPersonView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("", ContactPersonView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(ContactPersonView.Country, "[CH]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", ContactPersonView.AddressAddition);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("", ContactPersonView.Web);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}