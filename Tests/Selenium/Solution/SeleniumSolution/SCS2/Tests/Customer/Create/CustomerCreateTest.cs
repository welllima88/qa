using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
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

        private static string _adressAddition;
        private static string _cashIntegrator;
        private static string _agency;
        private static string _categoryCode;
        private static string _city;
        private static string _companyName;
        private static string _country;
        private static string _custId;
        private static string _customerName;
        private static string _segment;

        private static long _dt;
        private static string _email;
        private static string _fax;
        private static string _language;
        private static string _mobile;
        private static string _po;
        private static string _region;
        private static string _sapNumber;
        private static string _sbsBillingTenant;
        private static string _sbsCurrency;
        private static string _streetName;
        private static string _supplier;
        private static string _supportContract;
        private static string _telephone;
        private static string _web;
        private static string _zip;

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

            _driver.Url = _tb.BaseUrl + "/Default.aspx";
            _dt = DateTime.Now.Ticks; //timestamp for each test

            _supplier = "SIX Payment Services AG";
            _sbsCurrency = "EUR";
            _sbsBillingTenant = "SIX Payment Services (Europe)";
            _customerName = "SYR Kunde" + _dt;
            _categoryCode = "3364: AGENCY RENT-A-CAR";
            _supportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h";
            _cashIntegrator = "Wincor Nixdorf AG, Brüttisellen";
            _segment = "01_CH";
            _companyName = "SYR Sele Firma A";
            _streetName = "Hardturmstr. 201";
            _agency = "B05 Leiser Peter";
            _zip = "8021";
            _city = "Zürich";
            _po = "PFO1";
            _adressAddition = "Etage 3";
            _region = "Reg 3";
            _sapNumber = "4440";
            _language = "Deutsch [de]";
            _country = "Schweiz [CH]";
            _email = "marc.siegmund@six-group.com";
            _telephone = "0031 58 399 6237";
            _mobile = "0032 58 399 6237";
            _fax = "0033 58 399 6237";
            _web = "www.six-group.com/de-intern";

            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = _supplier;
            _customerCreate.SbsCurrency = _sbsCurrency;
            _customerCreate.SbsBillingTenant = _sbsBillingTenant;
            _customerCreate.CustomerName = _customerName;
            _customerCreate.CategoryCode = _categoryCode;
            _customerCreate.SupportContract = _supportContract;
            _customerCreate.CashIntegrator = _cashIntegrator;
            _customerCreate.Segment = _segment;
            _customerCreate.CompanyName = _companyName;
            _customerCreate.StreetName = _streetName;
            _customerCreate.Zip = _zip;
            _customerCreate.City = _city;
            _customerCreate.Po = _po;
            _customerCreate.AdressAddition = _adressAddition;
            _customerCreate.Region = _region;
            _customerCreate.SapNumber = _sapNumber;
            _customerCreate.Agency = _agency;
            _customerCreate.Language = _language;
            _customerCreate.Country = _country;
            _customerCreate.Email = _email;
            _customerCreate.Telephone = _telephone;
            _customerCreate.Mobile = _mobile;
            _customerCreate.Fax = _fax;
            _customerCreate.Web = _web;

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
            //_customerView.

            //after last test-method finished
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
            Assert.AreEqual(_sapNumber, _customerView.SapNumber);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual(_categoryCode, _customerView.CategoryCode);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual(_supportContract,
                            _customerView.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual(_cashIntegrator, _customerView.CashIntegrator);
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
            Assert.AreEqual(_po, _customerView.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, _customerView.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(_region, _customerView.Region);
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
            Assert.AreEqual(_agency, _customerView.Agency);
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
            Assert.AreEqual(_email, _customerView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, _customerView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, _customerView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, _customerView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, _customerView.Web);
        }

        [TestMethod]
        public void Segment()
        {
            Assert.AreEqual(_segment, _customerCreate.Segment);
        }
    }
}