using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Contact;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateTest
    {
        private static ContactCreate _contactCreate;
        private static ContactView _contactView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _customerMenu = new CustomerMenu(_driver);
            _contactCreate = new ContactCreate(_driver);
            _contactView = new ContactView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);

            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=401152";

            _customerMenu.ContactCreate.Click();

            _contactCreate.Salutation = "Herr";
            _contactCreate.FirstName = "Marc";
            _contactCreate.Name = "Siegmund SYR AUTO";
            _contactCreate.Language = "de";
            _contactCreate.Telephone = "+41 58 399 6237 - 1";
            _contactCreate.Mobile = "+41 58 399 6237 - 2";
            _contactCreate.Fax = "+41 58 399 6237 - 3";
            _contactCreate.Email = "contact@six-group.com";
            _contactCreate.Street = "Kontakt-Weg 1";
            _contactCreate.Po = "POC";
            _contactCreate.Zip = "55555";
            _contactCreate.City = "Berlin";
            _contactCreate.Region = "Mitte";
            _contactCreate.Country = "DE";
            _contactCreate.AddressAddition = "Zusatz1";

            _contactCreate.SaveButton.Click();
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual(_contactView.FirstName, "Marc");
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual(_contactView.Name, "Siegmund SYR AUTO");
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(_contactView.Language, "[de]");
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_contactView.Telephone, "+41 58 399 6237 - 1");
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_contactView.Mobile, "+41 58 399 6237 - 2");
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_contactView.Fax, "+41 58 399 6237 - 3");
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_contactView.Email, "contact@six-group.com");
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual(_contactView.Street, "Kontakt-Weg 1");
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_contactView.Po, "POC");
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_contactView.Zip, "55555");
        }

        [TestMethod]
        public void RegionCreateContactAndSave()
        {
            Assert.AreEqual(_contactView.Region, "Mitte");
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_contactView.City, "Berlin");
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(_contactView.Country, "[DE]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual(_contactView.AddressAddition, "Zusatz1");
        }

        [TestMethod]
        public void RecentElements()
        {
            string url = _driver.Url;
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();
            Assert.AreEqual(url, _driver.Url);
        }
    }
}