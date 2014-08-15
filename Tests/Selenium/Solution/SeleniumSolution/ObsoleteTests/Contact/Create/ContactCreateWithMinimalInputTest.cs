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

            Person.Create.Name = "Siegmund SYR AUTO";

            Person.Create.SaveButton.Click();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("", View.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", View.Name);
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(View.Language, "[de]");
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("", View.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", View.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", View.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", View.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("", View.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", View.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("", View.Zip);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", View.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("", View.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(View.Country, "[CH]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", View.AddressAddition);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("", View.Web);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}