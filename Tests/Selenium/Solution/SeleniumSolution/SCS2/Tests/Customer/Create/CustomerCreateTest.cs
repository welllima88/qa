using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateTest
    {
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
            _dt = TestLauncher.GenerateTestId();

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

            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();

            CustomerCreate.Supplier = _supplier;
            CustomerCreate.SbsCurrency = _sbsCurrency;
            CustomerCreate.SbsBillingTenant = _sbsBillingTenant;
            CustomerCreate.CustomerName = _customerName;
            CustomerCreate.CategoryCode = _categoryCode;
            CustomerCreate.SupportContract = _supportContract;
            CustomerCreate.CashIntegrator = _cashIntegrator;
            CustomerCreate.Segment = _segment;
            CustomerCreate.CompanyName = _companyName;
            CustomerCreate.StreetNo = _streetName;
            CustomerCreate.Zip = _zip;
            CustomerCreate.City = _city;
            CustomerCreate.Po = _po;
            CustomerCreate.AdressAddition = _adressAddition;
            CustomerCreate.Region = _region;
            CustomerCreate.SapNumber = _sapNumber;
            CustomerCreate.Agency = _agency;
            CustomerCreate.Language = _language;
            CustomerCreate.Country = _country;
            CustomerCreate.Email = _email;
            CustomerCreate.Telephone = _telephone;
            CustomerCreate.Mobile = _mobile;
            CustomerCreate.Fax = _fax;
            CustomerCreate.Web = _web;

            CustomerCreate.SaveButton.Click();

            _custId = CustomerView.CustomerNumber;
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
            CustomerMenu.CustomerDeactivate.Click();
            //CustomerView.            
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
        }

        [TestMethod]
        public void MostRecent()
        {
            string url = TestDirector.WebDriver.Url;

            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(url, TestDirector.WebDriver.Url, true);
            Assert.AreEqual(_custId, CustomerView.CustomerNumber);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, CustomerView.Supplier);
        }

        [TestMethod]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, CustomerView.SbsBillingTenant);
        }

        [TestMethod]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, CustomerView.SbsCurrency);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual(_sapNumber, CustomerView.SapNumber);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual(_categoryCode, CustomerView.CategoryCode);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual(_supportContract,
                            CustomerView.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual(_cashIntegrator, CustomerView.CashIntegrator);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, CustomerView.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, CustomerView.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(_region, CustomerView.Region);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetName, CustomerView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, CustomerView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, CustomerView.City);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual(_agency, CustomerView.Agency);
        }

        [TestMethod]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_language, CustomerView.Language);
        }

        [Ignore]
        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, CustomerView.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, CustomerView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, CustomerView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, CustomerView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, CustomerView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, CustomerView.Web);
        }

        [TestMethod]
        public void Segment()
        {
            Assert.AreEqual(_segment, CustomerView.Segment);
        }
    }
}