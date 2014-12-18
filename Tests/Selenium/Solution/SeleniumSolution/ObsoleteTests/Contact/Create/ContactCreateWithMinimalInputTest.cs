using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Create
{
    [TestFixture]
    public class ContactCreateWithMinimalInputTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            Person.Create.Name = "Siegmund SYR AUTO";

            Person.Create.SaveButton.Click();
        }

        [Test]
        public void AddressAddition()
        {
            Assert.AreEqual("", View.AddressAddition);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual("", View.City);
        }

        [Test]
        public void Country()
        {
            StringAssert.Contains(View.Country, "[CH]");
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual("", View.Email);
        }

        [Test]
        public void Fax()
        {
            Assert.AreEqual("", View.Fax);
        }

        [Test]
        public void FirstName()
        {
            Assert.AreEqual("", View.FirstName);
        }

        [Test]
        public void Language()
        {
            StringAssert.Contains(View.Language, "[de]");
        }

        [Test]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", View.Name);
        }

        [Test]
        public void Mobile()
        {
            Assert.AreEqual("", View.Mobile);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual("", View.Po);
        }

        [Test]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }

        [Test]
        public void Region()
        {
            Assert.AreEqual("", View.Region);
        }

        [Test]
        public void Street()
        {
            Assert.AreEqual("", View.StreetNo);
        }

        [Test]
        public void Telephone()
        {
            Assert.AreEqual("", View.Telephone);
        }

        [Test]
        public void Web()
        {
            Assert.AreEqual("", View.Web);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual("", View.Zip);
        }
    }
}