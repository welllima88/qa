using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMinimalInputTest
    {
        private static ContactPersonCreate _contactPersonCreate;
        private static ContactPersonView _contactPersonView;
        private static RecentElements _recentElements;
        private static CustomerMenu _customerMenu;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _contactPersonCreate = new ContactPersonCreate();
            _contactPersonView = new ContactPersonView();
            _recentElements = new RecentElements();
            _lobby = new LobbyView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _contactPersonCreate.FirstName = "Marc";
            _contactPersonCreate.Name = "Siegmund SYR AUTO";
            _contactPersonCreate.StreetNo = "Kontakt-Weg 1";
            _contactPersonCreate.Zip = "55555";
            _contactPersonCreate.City = "Berlin";

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
            Assert.AreEqual("", _contactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", _contactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", _contactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", _contactPersonView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", _contactPersonView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", _contactPersonView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", _contactPersonView.Zip);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", _contactPersonView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", _contactPersonView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(_contactPersonView.Country, "[CH]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", _contactPersonView.AddressAddition);
        }

        [TestMethod]
        public void RecentElements()
        {
            string url = TestLauncher.TestDirector.WebDriver.Url;
            _lobby.NavigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();
            Assert.AreEqual(TestLauncher.TestDirector.WebDriver.Url, url, false);
        }
    }
}