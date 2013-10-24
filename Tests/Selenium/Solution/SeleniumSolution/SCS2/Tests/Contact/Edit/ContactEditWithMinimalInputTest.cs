﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditWithMinimalInputTest
    {
        private static string _contactId;
        private static double _dt;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);
            _dt = TestLauncher.GenerateTestId();

            ContactMenu.ContactEdit.Click();

            ContactPersonEdit.Salutation = "";
            ContactPersonEdit.FirstName = "Marc" + _dt;
            ContactPersonEdit.Name = "Siegmund";
            ContactPersonEdit.Language = "fr";
            ContactPersonEdit.Telephone = "";
            ContactPersonEdit.Mobile = "";
            ContactPersonEdit.Fax = "";
            ContactPersonEdit.Email = "";
            ContactPersonEdit.Po = "";
            ContactPersonEdit.StreetNo = "Strasse 1";
            ContactPersonEdit.Zip = "2351";
            ContactPersonEdit.City = "City";
            ContactPersonEdit.Region = "";
            ContactPersonEdit.Country = "FR";
            ContactPersonEdit.AdressAddition = "Add";
            ContactPersonEdit.Web = "www.six-group.com";

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
            Assert.AreEqual("Marc" + _dt, ContactPersonView.FirstName);
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
            RecentElements.MostRecent.Click();
        }
    }
}