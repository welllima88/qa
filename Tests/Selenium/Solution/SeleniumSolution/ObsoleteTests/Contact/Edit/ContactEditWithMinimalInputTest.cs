using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Edit
{
    [TestFixture]
    public class ContactEditWithMinimalInputTest
    {
        private static string _contactId;
        private static string _dt;

        [TestFixtureSetUp]
        public static void TestInit()
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

        [Test]
        public void Salutation()
        {
            Assert.AreEqual("", View.Salutation);
        }

        [Test]
        public void FirstName()
        {
            Assert.AreEqual("", View.FirstName);
        }

        [Test]
        public void Name()
        {
            Assert.AreEqual("SYR" + _dt, View.Name);
        }

        [Test]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", View.Language);
        }

        [Test]
        public void Telephone()
        {
            Assert.AreEqual("", View.Telephone);
        }

        [Test]
        public void Mobile()
        {
            Assert.AreEqual("", View.Mobile);
        }

        [Test]
        public void Fax()
        {
            Assert.AreEqual("", View.Fax);
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual("", View.Email);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual("", View.Po);
        }

        [Test]
        public void StreetNo()
        {
            Assert.AreEqual("", View.StreetNo);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual("", View.Zip);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual("", View.City);
        }

        [Test]
        public void Region()
        {
            Assert.AreEqual("", View.Region);
        }

        [Test]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", View.Country);
        }

        [Test]
        [Ignore]
        public void Web()
        {
            Assert.AreEqual("", View.Web);
        }

        [Test]
        public void AddressAddition()
        {
            Assert.AreEqual("", View.AddressAddition);
        }

        [Test]
        public void MostRecentElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}