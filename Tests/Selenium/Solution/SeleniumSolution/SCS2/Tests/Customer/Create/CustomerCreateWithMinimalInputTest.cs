using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithMinimalInputTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;
        private static LobbyMenu _lobbyMenu;
        private static MenusTest _menusTests;
        private static Lobby _lobby;

        private static long _dt;
        private static string _custId;
        private static string _customerName;
        private static string _supplier;
        private static string _sbsCurrency;
        private static string _sbsBillingTenant;
        private static string _companyName;
        private static string _streetName;
        private static string _zip;
        private static string _city;
        private static string _language;
        private static string _country;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _lobbyMenu = new LobbyMenu(_driver);
            _customerMenu = new CustomerMenu(_driver);
            _customerCreate = new CustomerCreate(_driver);
            _customerView = new CustomerView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
            _menusTests = new MenusTest();
            _lobby = new Lobby(_driver);

            _driver.Url = _tb.BaseUrl + "/Default.aspx";
            _dt = DateTime.Now.Ticks; //timestamp for each test

            _customerName = "SYR Kunde" + _dt;
            _supplier = "SIX Payment Services AG";
            _sbsCurrency = "CHF";
            _sbsBillingTenant = "SIX Payment Services (Europe)";
            _companyName = "SYR Firma" + _dt;
            _streetName = "Hardturmstr. 201";
            _zip = "8021";
            _city = "Zürich";
            _language = "Deutsch [de]";
            _country = "Schweiz [CH]";

            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = _supplier;
            _customerCreate.SbsCurrency = _sbsCurrency;
            _customerCreate.SbsBillingTenant = _sbsBillingTenant;

            _customerCreate.CustomerName = _customerName;

            _customerCreate.CompanyName = _companyName;
            _customerCreate.StreetName = _streetName;
            _customerCreate.Zip = _zip;
            _customerCreate.City = _city;

            _customerCreate.Language = _language;
            _customerCreate.Country = _country;

            _customerCreate.SaveButton.Click();
            _custId = _customerView.CustomerNumber;
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
            _customerMenu.CustomerDeactivate.Click();
            _tb.ShutDownTest();
        }


        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, _customerView.CustomerName);
        }

        [TestMethod]
        public void MostRecent()
        {
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(_custId, _customerView.CustomerNumber);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, _customerView.Supplier);
        }

        [TestMethod]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, _customerView.SbsBillingTenant);
        }

        [TestMethod]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, _customerView.SbsCurrency);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual(" ", _customerView.SapNumber);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", _customerView.CategoryCode);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag",
                            _customerView.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", _customerView.CashIntegrator);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(" ", _customerView.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(" ", _customerView.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(" ", _customerView.Region);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetName, _customerView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, _customerView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, _customerView.City);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
        }

        [TestMethod]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_language, _customerView.Language);
        }

        [Ignore]
        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, _customerView.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(" ", _customerView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(" ", _customerView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(" ", _customerView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(" ", _customerView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(" ", _customerView.Web);
        }
    }
}