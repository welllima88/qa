using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class CustomerCreateTest
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

        private long _dt;

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
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Default.aspx";
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _customerMenu.CustomerDeactivate.Click();
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

            string supplier = "SIX Payment Services AG";
            string sbsCurrency = "EUR";
            string billingTenant = "SIX Payment Services (Europe)";
            string customerName = "SYR Kunde" + _dt;
            string categoryCode = "3364: AGENCY RENT-A-CAR";
            string supportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h";
            string cashIntegrator = "Wincor Nixdorf AG, Brüttisellen";
            string companyName = "SYR Sele Firma A";
            string streetName = "Hardturmstr. 201";
            string zip = "8021";
            string city = "Zürich";
            string po = "PFO1";
            string adressAddition = "Etage 3";
            string region = "Reg 3";
            string sapNumber = "4440";
            string language = "Deutsch [de]";
            string country = "Schweiz [CH]";
            string email = "marc.siegmund@six-group.com";
            string telephone = "0031 58 399 6237";
            string mobile = "0032 58 399 6237";
            string fax = "0033 58 399 6237";
            string web = "www.six-group.com/de-intern";
            _customerCreate.Supplier = supplier;
            _customerCreate.SbsCurrency = sbsCurrency;
            _customerCreate.SbsBillingTenant = billingTenant;
            _customerCreate.CustomerName = customerName;
            _customerCreate.CategoryCode = categoryCode;
            _customerCreate.SupportContract = supportContract;
            _customerCreate.CashIntegrator = cashIntegrator;
            _customerCreate.CompanyName = companyName;
            _customerCreate.StreetName = streetName;
            _customerCreate.Zip = zip;
            _customerCreate.City = city;
            _customerCreate.Po = po;
            _customerCreate.AdressAddition = adressAddition;
            _customerCreate.Region = region;
            _customerCreate.SapNumber = sapNumber;
            _customerCreate.Agency = billingTenant;
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

            //check/read customerId
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(customerName, _customerView.CustomerName);
            Assert.AreEqual(supplier, _customerView.Supplier);
            Assert.AreEqual(billingTenant, _customerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _customerView.SbsCurrency);
            Assert.AreEqual(sapNumber, _customerView.SapNumber);
            Assert.AreEqual(categoryCode, _customerView.CategoryCode);
            Assert.AreEqual(supportContract,
                            _customerView.SupportContract);
            Assert.AreEqual(cashIntegrator, _customerView.CashIntegrator);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _customerView.CompanyName);
            Assert.AreEqual(po, _customerView.Po);
            Assert.AreEqual(adressAddition, _customerView.AdressAddition);
            Assert.AreEqual(region, _customerView.Region);
            Assert.AreEqual(streetName, _customerView.StreetName);
            Assert.AreEqual(zip, _customerView.Zip);
            Assert.AreEqual(city, _customerView.City);
            Assert.AreEqual(billingTenant, _customerView.Agency);
            Assert.AreEqual(language, _customerView.Language);
            Assert.AreEqual(country, _customerView.Country);
            Assert.AreEqual(email, _customerView.Email);
            Assert.AreEqual(telephone, _customerView.Telephone);
            Assert.AreEqual(mobile, _customerView.Mobile);
            Assert.AreEqual(fax, _customerView.Fax);
            Assert.AreEqual(web, _customerView.Web);
        }

        [TestMethod]
        public void CreateCustomerWithMinimalAndSaveWithMenuCheck()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "CHF";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Kunde" + _dt;

            _customerCreate.CompanyName = "SYR Firma" + _dt;
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "8021";
            _customerCreate.City = "Zürich";

            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;
            _menusTests.CustomerMenuCheck(_customerMenu);

            //check/read customerId
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(" ", _customerView.SapNumber);
            Assert.AreEqual("SYR Kunde" + _dt, _customerView.CustomerName);
            StringAssert.Matches(_customerView.Guid, TestRegExpPatterns.Guid);
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            Assert.AreEqual("CHF", _customerView.SbsCurrency);
            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);
            Assert.AreEqual("(Keine Branche)", _customerView.CategoryCode);
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
            Assert.AreEqual("Kein Supportvertrag", _customerView.SupportContract);
            Assert.AreEqual("Kein Kassenintegrator", _customerView.CashIntegrator);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
            Assert.AreEqual("SIX Payment Services (Europe)", _customerView.SbsBillingTenant);
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("SYR Firma" + _dt, _customerView.CompanyName);
            Assert.AreEqual(" ", _customerView.Po);
            Assert.AreEqual(" ", _customerView.AdressAddition);
            Assert.AreEqual(" ", _customerView.Region);
            Assert.AreEqual("Hardturmstr. 201", _customerView.StreetName);
            Assert.AreEqual("8021", _customerView.Zip);
            Assert.AreEqual("Zürich", _customerView.City);
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
            Assert.AreEqual("Deutsch [de]", _customerView.Language);
            Assert.AreEqual("Schweiz [CH]", _customerView.Country);
            Assert.AreEqual(" ", _customerView.Email);
            Assert.AreEqual(" ", _customerView.Telephone);
            Assert.AreEqual(" ", _customerView.Mobile);
            Assert.AreEqual(" ", _customerView.Fax);
            Assert.AreEqual("", _customerView.Web);
        }


        [TestMethod]
        public void CreateCustomerCheckNavBar()
        {
            _customerMenu.CustomerCreate.Click();
            Assert.AreEqual("Neuer Kunde", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateCustomerCheckHeadline()
        {
            StringAssert.Contains("Lobby", _lobby.Headline.Text);
            _customerMenu.CustomerCreate.Click();
            Assert.AreEqual("Neuer Kunde", _lobby.Headline.Text);
        }

        [TestMethod]
        public void CreateCustomerMenu()
        {
            _menusTests.LobbyMenu(_lobbyMenu);
            _customerMenu.CustomerCreate.Click();
        }
    }
}