using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Person;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateTest
    {
        private static PersonCreate _personCreate;
        private static PersonView _personView;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _personCreate = new PersonCreate();
            _personView = new PersonView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401152");

            _customerMenu.ContactCreate.Click();

            _personCreate.Salutation = "Herr";
            _personCreate.FirstName = "Marc";
            _personCreate.Name = "Siegmund SYR AUTO";
            _personCreate.Language = "de";
            _personCreate.Telephone = "+41 58 399 6237 - 1";
            _personCreate.Mobile = "+41 58 399 6237 - 2";
            _personCreate.Fax = "+41 58 399 6237 - 3";
            _personCreate.Email = "contact@six-group.com";
            _personCreate.StreetNo = "Kontakt-Weg 1";
            _personCreate.Po = "POC";
            _personCreate.Zip = "55555";
            _personCreate.City = "Berlin";
            _personCreate.Region = "Mitte";
            _personCreate.Country = "DE";
            _personCreate.AddressAddition = "Zusatz1";

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
            Assert.AreEqual("+41 58 399 6237 - 1", _personView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("+41 58 399 6237 - 2", _personView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("+41 58 399 6237 - 3", _personView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("contact@six-group.com", _personView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", _personView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("POC", _personView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", _personView.Zip);
        }

        [TestMethod]
        public void RegionCreateContactAndSave()
        {
            Assert.AreEqual("Mitte", _personView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", _personView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(_personView.Country, "[DE]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("Zusatz1", _personView.AddressAddition);
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