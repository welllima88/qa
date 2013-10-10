using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateTest
    {
        private static ContactPersonCreate ContactPersonCreate;
        private static ContactPersonView ContactPersonView;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static CustomerMenu CustomerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerMenu = new CustomerMenu();
            ContactPersonCreate = new ContactPersonCreate();
            ContactPersonView = new ContactPersonView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.Salutation = "Herr";
            ContactPersonCreate.FirstName = "Marc";
            ContactPersonCreate.Name = "Siegmund SYR AUTO";
            ContactPersonCreate.Language = "de";
            ContactPersonCreate.Telephone = "+41 58 399 6237 - 1";
            ContactPersonCreate.Mobile = "+41 58 399 6237 - 2";
            ContactPersonCreate.Fax = "+41 58 399 6237 - 3";
            ContactPersonCreate.Email = "contact@six-group.com";
            ContactPersonCreate.StreetNo = "Kontakt-Weg 1";
            ContactPersonCreate.Po = "POC";
            ContactPersonCreate.Zip = "55555";
            ContactPersonCreate.City = "Berlin";
            ContactPersonCreate.Region = "Mitte";
            ContactPersonCreate.Country = "DE";
            ContactPersonCreate.AddressAddition = "Zusatz1";

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
            Assert.AreEqual("+41 58 399 6237 - 1", ContactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("+41 58 399 6237 - 2", ContactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("+41 58 399 6237 - 3", ContactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("contact@six-group.com", ContactPersonView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("POC", ContactPersonView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", ContactPersonView.Zip);
        }

        [TestMethod]
        public void RegionCreateContactAndSave()
        {
            Assert.AreEqual("Mitte", ContactPersonView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", ContactPersonView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(ContactPersonView.Country, "[DE]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("Zusatz1", ContactPersonView.AddressAddition);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            string url = TestLauncher.TestDirector.WebDriver.Url;
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();
            Assert.AreEqual(url, TestLauncher.TestDirector.WebDriver.Url);
        }
    }
}