using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

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
            TestDirector.Navigate();

            DoCreateCustomer();

            _custId = CustomerView.CustomerNumber;
        }

        public static void DoCreateCustomer()
        {
            _dt = TestLauncher.GenerateTestId();

            CustomerMenu.CustomerCreate.Click();

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
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CustomerNumber()
        {
            StringAssert.Matches(CustomerView.CustomerNumber, TestRegExpPatterns.CustomerNo);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, CustomerView.Supplier);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, CustomerView.SbsBillingTenant);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, CustomerView.SbsCurrency);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SapNumber()
        {
            Assert.AreEqual(_sapNumber, CustomerView.SapNumber);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        [Ignore] //because it is like other suggestors not reliable test
        public void CategoryCode()
        {
            Assert.AreEqual(_categoryCode, CustomerView.CategoryCode);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SupportContract()
        {
            Assert.AreEqual(_supportContract,
                            CustomerView.SupportContract);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CashIntegrator()
        {
            Assert.AreEqual(_cashIntegrator, CustomerView.CashIntegrator);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Ep2MerchantId()
        {
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Po()
        {
            Assert.AreEqual(_po, CustomerView.Po);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, CustomerView.AdressAddition);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Region()
        {
            Assert.AreEqual(_region, CustomerView.Region);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void StreetNo()
        {
            Assert.AreEqual(_streetName, CustomerView.StreetNo);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Zip()
        {
            Assert.AreEqual(_zip, CustomerView.Zip);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void City()
        {
            Assert.AreEqual(_city, CustomerView.City);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Agency()
        {
            Assert.AreEqual(_agency, CustomerView.Agency);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_language, CustomerView.Language);
        }

        [Ignore]
        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Country()
        {
            Assert.AreEqual(_country, CustomerView.Country);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Email()
        {
            Assert.AreEqual(_email, CustomerView.Email);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, CustomerView.Telephone);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, CustomerView.Mobile);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Fax()
        {
            Assert.AreEqual(_fax, CustomerView.Fax);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Web()
        {
            Assert.AreEqual(_web, CustomerView.Web);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Segment()
        {
            Assert.AreEqual(_segment, CustomerView.Segment);
        }

        public static void Check()
        {
            // TODO:includes checks when suggester are removed
            StringAssert.Matches(CustomerView.CustomerNumber, TestRegExpPatterns.CustomerNo);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
            Assert.AreEqual(_supplier, CustomerView.Supplier);
            Assert.AreEqual(_sbsBillingTenant, CustomerView.SbsBillingTenant);
            StringAssert.Contains(CustomerView.SbsCurrency.ToUpper(), _sbsCurrency);
            Assert.AreEqual(_sapNumber, CustomerView.SapNumber);
            // Assert.AreEqual(_categoryCode, CustomerView.CategoryCode);
            Assert.AreEqual(_supportContract,CustomerView.SupportContract);
            Assert.AreEqual(_cashIntegrator, CustomerView.CashIntegrator);
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
            Assert.AreEqual(_po, CustomerView.Po);
            Assert.AreEqual(_adressAddition, CustomerView.AdressAddition);
            Assert.AreEqual(_region, CustomerView.Region);
            Assert.AreEqual(_streetName, CustomerView.StreetNo);
            Assert.AreEqual(_zip, CustomerView.Zip);
            Assert.AreEqual(_city, CustomerView.City);
            Assert.AreEqual(_agency, CustomerView.Agency);
            // Assert.AreEqual(_language, CustomerView.Language);
            // Assert.AreEqual(_country, CustomerView.Country);
            Assert.AreEqual(_email, CustomerView.Email);
            Assert.AreEqual(_telephone, CustomerView.Telephone);
            Assert.AreEqual(_mobile, CustomerView.Mobile);
            Assert.AreEqual(_fax, CustomerView.Fax);
            Assert.AreEqual(_web, CustomerView.Web);
            Assert.AreEqual(_segment, CustomerView.Segment);
        }
    }
}