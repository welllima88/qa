using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateWithMinimalInputTest
    {
        private static PersonCreate _personCreate;
        private static PersonView _personView;
        private static RecentElements _recentElements;
        private static CustomerMenu _customerMenu;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _personCreate = new PersonCreate();
            _personView = new PersonView();
            _recentElements = new RecentElements();
            _lobby = new LobbyView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _personCreate.FirstName = "Marc";
            _personCreate.Name = "Siegmund SYR AUTO";
            _personCreate.StreetNo = "Kontakt-Weg 1";
            _personCreate.Zip = "55555";
            _personCreate.City = "Berlin";

            _personCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("Marc", _personView.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", _personView.Name);
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(_personView.Language, "[de]");
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("", _personView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", _personView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", _personView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", _personView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", _personView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", _personView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", _personView.Zip);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", _personView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", _personView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(_personView.Country, "[CH]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("", _personView.AddressAddition);
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