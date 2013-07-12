﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMinimalInputTest
    {
        private static ContactCreate _contactCreate;
        private static ContactView _contactView;
        private static IWebDriverAdapter _driver;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _customerMenu = new CustomerMenu(_driver);
            _contactCreate = new ContactCreate(_driver);
            _contactView = new ContactView(_driver);
            _recentElements = new RecentElements(_driver);
            _lobby = new LobbyView(_driver);

            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=401152";

            _customerMenu.ContactCreate.Click();

            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";

            _contactCreate.SaveButton.Click();
        }

        [TestInitialize]
        public void TestInit()
        {
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
        public void FirstName()
        {
            Assert.AreEqual("Marc", _contactView.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", _contactView.Name);
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(_contactView.Language, "[de]");
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("", _contactView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", _contactView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", _contactView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", _contactView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", _contactView.Street);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", _contactView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", _contactView.Zip);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", _contactView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", _contactView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(_contactView.Country, "[CH]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", _contactView.AddressAddition);
        }

        [TestMethod]
        public void RecentElements()
        {
            string url = _driver.Url;
            _lobby.NavigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();
            Assert.AreEqual(_driver.Url, url, false);
        }
    }
}