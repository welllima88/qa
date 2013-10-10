using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMinimalInputTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.FirstName = "Marc";
            ContactPersonCreate.Name = "Siegmund SYR AUTO";
            ContactPersonCreate.StreetNo = "Kontakt-Weg 1";
            ContactPersonCreate.Zip = "55555";
            ContactPersonCreate.City = "Berlin";

            ContactPersonCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("Marc", ContactPersonView.FirstName);
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
            Assert.AreEqual("Kontakt-Weg 1", ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", ContactPersonView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", ContactPersonView.Zip);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", ContactPersonView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", ContactPersonView.City);
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
        public void RecentElementsCheck()
        {
            string url = TestLauncher.TestDirector.WebDriver.Url;
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();
            Assert.AreEqual(TestLauncher.TestDirector.WebDriver.Url, url, false);
        }
    }
}