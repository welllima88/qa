using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
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

            View.EditButton.Click();

            Person.Edit.Salutation = "";
            Person.Edit.FirstName = "";
            Person.Edit.Name = "SYR" + _dt;
            Person.Edit.Language = "fr";
            Person.Edit.Telephone = "";
            Person.Edit.Mobile = "";
            Person.Edit.Fax = "";
            Person.Edit.Email = "";
            Person.Edit.Po = "";
            Person.Edit.StreetNo = "";
            Person.Edit.Zip = "";
            Person.Edit.City = "";
            Person.Edit.Region = "";
            Person.Edit.Country = "FR";
            Person.Edit.AdressAddition = "";
            Person.Edit.Web = "";

            Person.Edit.SaveButton.Click();
        }

        [TestMethod]
        public void Salutation()
        {
            Assert.AreEqual("", View.Salutation);
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("", View.FirstName);
        }

        [TestMethod]
        public void Name()
        {
            Assert.AreEqual("SYR" + _dt, View.Name);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", View.Language);
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
        public void Po()
        {
            Assert.AreEqual("", View.Po);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("", View.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("", View.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("", View.City);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", View.Region);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", View.Country);
        }

        [TestMethod]
        [Ignore]
        public void Web()
        {
            Assert.AreEqual("", View.Web);
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", View.AddressAddition);
        }

        [TestMethod]
        public void MostRecentElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}