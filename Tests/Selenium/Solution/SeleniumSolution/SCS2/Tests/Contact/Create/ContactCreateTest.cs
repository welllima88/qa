using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateTest
    {
        private static ContactPersonCreate _contactPersonCreate;
        private static ContactPersonView _contactPersonView;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _contactPersonCreate = new ContactPersonCreate();
            _contactPersonView = new ContactPersonView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.Salutation = "Herr";
            _contactPersonCreate.FirstName = "Marc";
            _contactPersonCreate.Name = "Siegmund SYR AUTO";
            _contactPersonCreate.Language = "de";
            _contactPersonCreate.Telephone = "+41 58 399 6237 - 1";
            _contactPersonCreate.Mobile = "+41 58 399 6237 - 2";
            _contactPersonCreate.Fax = "+41 58 399 6237 - 3";
            _contactPersonCreate.Email = "contact@six-group.com";
            _contactPersonCreate.StreetNo = "Kontakt-Weg 1";
            _contactPersonCreate.Po = "POC";
            _contactPersonCreate.Zip = "55555";
            _contactPersonCreate.City = "Berlin";
            _contactPersonCreate.Region = "Mitte";
            _contactPersonCreate.Country = "DE";
            _contactPersonCreate.AddressAddition = "Zusatz1";

            _contactPersonCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("Marc", _contactPersonView.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", _contactPersonView.Name);
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(_contactPersonView.Language, "[de]");
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("+41 58 399 6237 - 1", _contactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("+41 58 399 6237 - 2", _contactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("+41 58 399 6237 - 3", _contactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("contact@six-group.com", _contactPersonView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", _contactPersonView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("POC", _contactPersonView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", _contactPersonView.Zip);
        }

        [TestMethod]
        public void RegionCreateContactAndSave()
        {
            Assert.AreEqual("Mitte", _contactPersonView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", _contactPersonView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(_contactPersonView.Country, "[DE]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("Zusatz1", _contactPersonView.AddressAddition);
        }

        [TestMethod]
        public void RecentElements()
        {
            string url = TestLauncher.TestDirector.WebDriver.Url;
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();
            Assert.AreEqual(url, TestLauncher.TestDirector.WebDriver.Url);
        }
    }
}