using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class CoopCustomerCreateTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
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
            _customerCreate = new CustomerCreate(_driver);
            _customerView = new CustomerView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Default.aspx";
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
        public void CreateCoopCustomerMinimalAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            string supplier = "Coop ep2";
            string customerName = "SYR Coop ep2 Kunde";
            string companyName = "SYR Coop ep2 Firma";
            string streetName = "Bahnhofstr. 23a";
            string zip = "8001";
            string city = "Zürich";

            _customerCreate.Supplier = supplier;
            _customerCreate.CompanyName = companyName;
            _customerCreate.StreetName = streetName;
            _customerCreate.Zip = zip;
            _customerCreate.City = city;
            _customerCreate.CustomerName = customerName;

            _customerCreate.SaveButton.Click();

            Assert.AreEqual(customerName, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(customerName, _customerView.CustomerName);
            Assert.AreEqual(supplier, _customerView.Supplier);

            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _customerView.CompanyName);
            Assert.AreEqual("", _customerView.Po);
            Assert.AreEqual("", _customerView.AdressAddition);
            Assert.AreEqual("", _customerView.Region);
            Assert.AreEqual(streetName, _customerView.StreetName);
            Assert.AreEqual(zip, _customerView.Zip);
            Assert.AreEqual(city, _customerView.City);
            Assert.AreEqual("Deutsch [de]", _customerView.Language);
            Assert.AreEqual("Schweiz [CH]", _customerView.Country);
            Assert.AreEqual("", _customerView.Email);
            Assert.AreEqual("", _customerView.Telephone);
            Assert.AreEqual("", _customerView.Mobile);
            Assert.AreEqual("", _customerView.Fax);
            Assert.AreEqual("", _customerView.Web);
        }

        [TestMethod]
        public void CreateCoopDivisionCustomerAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            string supplier = "Coop Divisionen";
            string categoryCode = "3663: HOTELES EL PRESIDENTE";
            string customerName = "SYR Coop Division Kunde";
            string companyName = "SYR Coop Firma";
            string streetName = "Pronto 1a";
            string zip = "8008";
            string city = "Zürich";
            string po = "COO2";
            string adressAddition = "TakeAway";
            string region = "ZH-W";
            string sapNumber = "2244";
            string agency = "SIX LUX";
            string language = "Französisch [fr]";
            string country = "Luxemburg [LU]";
            string email = "marc.siegmund@six-group.com/coop";
            string telephone = "00 61 58 399 6237";
            string mobile = "00 62 58 399 6237";
            string fax = "00 63 58 399 6237";
            string web = "www.six-group.com/coop";

            _customerCreate.Supplier = supplier;
            _customerCreate.CategoryCode = categoryCode;
            _customerCreate.CustomerName = customerName;
            _customerCreate.CompanyName = companyName;
            _customerCreate.StreetName = streetName;
            _customerCreate.Zip = zip;
            _customerCreate.City = city;
            _customerCreate.Po = po;
            _customerCreate.AdressAddition = adressAddition;
            _customerCreate.Region = region;
            _customerCreate.SapNumber = sapNumber;

            _customerCreate.Agency = agency;
            _customerCreate.Language = language;
            _customerCreate.Country = country;
            _customerCreate.Email = email;
            _customerCreate.Telephone = telephone;
            _customerCreate.Mobile = mobile;
            _customerCreate.Fax = fax;
            _customerCreate.Web = web;

            _customerCreate.SaveButton.Click();

            Assert.AreEqual(customerName, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(customerName, _customerView.CustomerName);
            Assert.AreEqual(supplier, _customerView.Supplier);
            Assert.AreEqual(sapNumber, _customerView.SapNumber);
            Assert.AreEqual(categoryCode, _customerView.CategoryCode);

            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _customerView.CompanyName);
            Assert.AreEqual(po, _customerView.Po);
            Assert.AreEqual(adressAddition, _customerView.AdressAddition);
            Assert.AreEqual(region, _customerView.Region);
            Assert.AreEqual(streetName, _customerView.StreetName);
            Assert.AreEqual(zip, _customerView.Zip);
            Assert.AreEqual(city, _customerView.City);
            Assert.AreEqual(agency, _customerView.Agency);
            Assert.AreEqual(language, _customerView.Language);
            Assert.AreEqual(country, _customerView.Country);
            Assert.AreEqual(email, _customerView.Email);
            Assert.AreEqual(telephone, _customerView.Telephone);
            Assert.AreEqual(mobile, _customerView.Mobile);
            Assert.AreEqual(fax, _customerView.Fax);
            Assert.AreEqual(web, _customerView.Web);
        }
    }
}