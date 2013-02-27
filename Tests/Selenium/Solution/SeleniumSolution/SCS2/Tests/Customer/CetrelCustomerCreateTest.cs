using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class CetrelCustomerCreateTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static IWebDriver _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new Scs2TestDirector();
            _driver = _tb.SetupTest(); //default QA-L with certificate login and 10 seconds response timeout
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
        public void CreateCustomerAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            string supplier = "CETREL S.A.";
            _customerCreate.Supplier = supplier;
            string categoryCode = "3663: HOTELES EL PRESIDENTE";
            _customerCreate.CategoryCode = categoryCode;
            string supportContract = "SPA Servicepaket Advance";
            _customerCreate.SupportContract = supportContract;
            string customerSegment = "07_P_CETREL";
            _customerCreate.CustomerSegment = customerSegment;
            string customerName = "SYR Cetrel Kunde Create";
            _customerCreate.CustomerName = customerName;
            string companyName = "SYR Cetrel Firma Create";
            _customerCreate.CompanyName = companyName;
            string streetName = "Luxemburgerli 1a";
            _customerCreate.StreetName = streetName;
            string zip = "11247";
            _customerCreate.Zip = zip;
            string city = "Luxemburg";
            _customerCreate.City = city;
            string po = "LUX1";
            _customerCreate.Po = po;
            string adressAddition = "ZusatzLUX";
            _customerCreate.AdressAddition = adressAddition;
            string region = "WestLUX";
            _customerCreate.Region = region;
            string sapNumber = "9129";
            _customerCreate.SapNumber = sapNumber;

            string agency = "SIX LUX";
            _customerCreate.Agency = agency;
            string language = "Französisch [fr]";
            _customerCreate.Language = language;
            string country = "Luxemburg [LU]";
            _customerCreate.Country = country;
            string email = "marc.siegmund@six-group.com/lux";
            _customerCreate.Email = email;
            string telephone = "+61 58 399 6237";
            _customerCreate.Telephone = telephone;
            string mobile = "+62 58 399 6237";
            _customerCreate.Mobile = mobile;
            string fax = "+63 58 399 6237";
            _customerCreate.Fax = fax;
            string web = "www.six-group.com/cetrel";
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
            Assert.AreEqual(supportContract,
                            _customerView.SupportContract);

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