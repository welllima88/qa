using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSClassics;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.Integration
{
    /// <summary>
    /// Summary description for TerminalFunctionTests
    /// </summary>
    [TestClass]
    public class CustomerCreateIntegrationTest
    {
        private static TestDirector _scs;
        private static TestDirector _zebra;
        private static CustomerCreate _zebraCustomerCreate;
        private static CustomerView _zebraCustomerView;

        private static SCSClassics.TestObjects.Customer.CustomerCreate _scsCustomerCreate;
        private static SCSClassics.TestObjects.Customer.CustomerView _scsCustomerView;
        private string _customerName = "";
        private string adressAddition = "Etage 3";
        private string billingTenant = "SIX Payment Services (Europe)";
        private string cashIntegrator = "Wincor Nixdorf AG, Brüttisellen";
        private string categoryCode = "3364: AGENCY RENT-A-CAR";
        private string city = "Zürich";
        private string companyName = "SYR Sele Firma A";
        private string country = "Schweiz [CH]";
        private string email = "marc.siegmund@six-group.com";
        private string fax = "0033 58 399 6237";
        private string language = "Deutsch [de]";
        private string mobile = "0032 58 399 6237";
        private string po = "PFO1";
        private string region = "Reg 3";
        private string sapNumber = "4440";
        private string sbsCurrency = "EUR";
        private string streetName = "Hardturmstr. 201";
        private string supplier = "SIX Payment Services AG";
        private string supportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h";
        private string telephone = "0031 58 399 6237";
        private string web = "www.six-group.com/de-intern";
        private string zip = "8021";

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>8
        public TestContext TestContext { get; set; }

        #region Additional test attributes

        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            _zebra = new ScsPlatinTestDirector();
            _scs = new ScsClassicTestDirector();

            _zebra.DefaultTestSetup();
            _scs.DefaultTestSetup();

            _zebraCustomerView = new CustomerView(_zebra.WebDriver);
            _zebraCustomerCreate = new CustomerCreate(_zebra.WebDriver);
            _scsCustomerView = new SCSClassics.TestObjects.Customer.CustomerView(_zebra.WebDriver);
            _scsCustomerCreate = new SCSClassics.TestObjects.Customer.CustomerCreate(_zebra.WebDriver);
        }

        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //

        #endregion

        [TestInitialize]
        public void TestInit()
        {
            _customerName = "SYR Kunde" + DateTime.Now.Ticks;
        }

        [TestMethod]
        public void CreateCustomerInZebraSaveAndCompare()
        {
            _zebra.WebDriver.Url = "/Pages/Customer/CustomerEdit.aspx?PageMode=new";
            _zebraCustomerCreate.Supplier = supplier;
            _zebraCustomerCreate.SbsCurrency = sbsCurrency;
            _zebraCustomerCreate.SbsBillingTenant = billingTenant;
            _zebraCustomerCreate.CustomerName = _customerName;
            _zebraCustomerCreate.CategoryCode = categoryCode;
            _zebraCustomerCreate.SupportContract = supportContract;
            _zebraCustomerCreate.CashIntegrator = cashIntegrator;
            _zebraCustomerCreate.CompanyName = companyName;
            _zebraCustomerCreate.StreetName = streetName;
            _zebraCustomerCreate.Zip = zip;
            _zebraCustomerCreate.City = city;
            _zebraCustomerCreate.Po = po;
            _zebraCustomerCreate.AdressAddition = adressAddition;
            _zebraCustomerCreate.Region = region;
            _zebraCustomerCreate.SapNumber = sapNumber;
            _zebraCustomerCreate.Agency = billingTenant;
            _zebraCustomerCreate.Language = language;
            _zebraCustomerCreate.Country = country;
            _zebraCustomerCreate.Email = email;
            _zebraCustomerCreate.Telephone = telephone;
            _zebraCustomerCreate.Mobile = mobile;
            _zebraCustomerCreate.Fax = fax;
            _zebraCustomerCreate.Web = web;

            _zebraCustomerCreate.SaveButton.Click();

            Assert.AreEqual(_customerName, _scsCustomerView.CustomerName);
            string custId = _scsCustomerView.CustomerNumber;

            Assert.AreEqual(custId, _zebraCustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, _zebraCustomerView.CustomerName);
            Assert.AreEqual(supplier, _zebraCustomerView.Supplier);
            Assert.AreEqual(billingTenant, _zebraCustomerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _zebraCustomerView.SbsCurrency);
            Assert.AreEqual(sapNumber, _zebraCustomerView.SapNumber);
            Assert.AreEqual(categoryCode, _zebraCustomerView.CategoryCode);
            Assert.AreEqual(supportContract,
                            _zebraCustomerView.SupportContract);
            Assert.AreEqual(cashIntegrator, _zebraCustomerView.CashIntegrator);

            StringAssert.Matches(_zebraCustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_zebraCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_zebraCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_zebraCustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _zebraCustomerView.CompanyName);
            Assert.AreEqual(po, _zebraCustomerView.Po);
            Assert.AreEqual(adressAddition, _zebraCustomerView.AdressAddition);
            Assert.AreEqual(region, _zebraCustomerView.Region);
            Assert.AreEqual(streetName, _zebraCustomerView.StreetName);
            Assert.AreEqual(zip, _zebraCustomerView.Zip);
            Assert.AreEqual(city, _zebraCustomerView.City);
            Assert.AreEqual(billingTenant, _zebraCustomerView.Agency);
            Assert.AreEqual(language, _zebraCustomerView.Language);
            Assert.AreEqual(country, _zebraCustomerView.Country);
            Assert.AreEqual(email, _zebraCustomerView.Email);
            Assert.AreEqual(telephone, _zebraCustomerView.Telephone);
            Assert.AreEqual(mobile, _zebraCustomerView.Mobile);
            Assert.AreEqual(fax, _zebraCustomerView.Fax);
            Assert.AreEqual(web, _zebraCustomerView.Web);

            _scs.WebDriver.Url = "/Customer.asp?CustomerFunction=24&CustomerId=" + custId;

            Assert.AreEqual(_customerName, _scsCustomerView.CustomerName);

            Assert.AreEqual(custId, _scsCustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, _scsCustomerView.CustomerName);
            Assert.AreEqual(supplier, _scsCustomerView.Supplier);
            Assert.AreEqual(billingTenant, _scsCustomerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _scsCustomerView.SbsCurrency);
            Assert.AreEqual(sapNumber, _scsCustomerView.SapNumber);
            Assert.AreEqual(categoryCode, _scsCustomerView.CategoryCode);
            Assert.AreEqual(supportContract,
                            _scsCustomerView.SupportContract);
            Assert.AreEqual(cashIntegrator, _scsCustomerView.CashIntegrator);

            StringAssert.Matches(_scsCustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_scsCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_scsCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_scsCustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _scsCustomerView.CompanyName);
            Assert.AreEqual(po, _scsCustomerView.Po);
            Assert.AreEqual(adressAddition, _scsCustomerView.AdressAddition);
            Assert.AreEqual(region, _scsCustomerView.Region);
            Assert.AreEqual(streetName, _scsCustomerView.StreetName);
            Assert.AreEqual(zip, _scsCustomerView.Zip);
            Assert.AreEqual(city, _scsCustomerView.City);
            Assert.AreEqual(billingTenant, _scsCustomerView.Agency);
            Assert.AreEqual(language, _scsCustomerView.Language);
            Assert.AreEqual(country, _scsCustomerView.Country);
            Assert.AreEqual(email, _scsCustomerView.Email);
            Assert.AreEqual(telephone, _scsCustomerView.Telephone);
            Assert.AreEqual(mobile, _scsCustomerView.Mobile);
            Assert.AreEqual(fax, _scsCustomerView.Fax);
            Assert.AreEqual(web, _scsCustomerView.Web);
        }

        [TestMethod]
        public void CreateCustomerInScsSaveAndCompare()
        {
            _scs.WebDriver.Url = "/CustomerNew.asp";

            _scsCustomerCreate.Supplier = supplier;
            _scsCustomerCreate.SbsCurrency = sbsCurrency;
            _scsCustomerCreate.SbsBillingTenant = billingTenant;
            _scsCustomerCreate.CustomerName = _customerName;
            _scsCustomerCreate.CategoryCode = categoryCode;
            _scsCustomerCreate.SupportContract = supportContract;
            _scsCustomerCreate.CashIntegrator = cashIntegrator;
            _scsCustomerCreate.CompanyName = companyName;
            _scsCustomerCreate.StreetName = streetName;
            _scsCustomerCreate.Zip = zip;
            _scsCustomerCreate.City = city;
            _scsCustomerCreate.Po = po;
            _scsCustomerCreate.AdressAddition = adressAddition;
            _scsCustomerCreate.Region = region;
            _scsCustomerCreate.SapNumber = sapNumber;
            _scsCustomerCreate.Agency = billingTenant;
            _scsCustomerCreate.Language = language;
            _scsCustomerCreate.Country = country;
            _scsCustomerCreate.Email = email;
            _scsCustomerCreate.Telephone = telephone;
            _scsCustomerCreate.Mobile = mobile;
            _scsCustomerCreate.Fax = fax;
            _scsCustomerCreate.Web = web;

            _scsCustomerCreate.SaveButton.Click();

            Assert.AreEqual(_customerName, _scsCustomerView.CustomerName);
            string custId = _scsCustomerView.CustomerNumber;

            Assert.AreEqual(custId, _scsCustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, _scsCustomerView.CustomerName);
            Assert.AreEqual(supplier, _scsCustomerView.Supplier);
            Assert.AreEqual(billingTenant, _scsCustomerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _scsCustomerView.SbsCurrency);
            Assert.AreEqual(sapNumber, _scsCustomerView.SapNumber);
            Assert.AreEqual(categoryCode, _scsCustomerView.CategoryCode);
            Assert.AreEqual(supportContract,
                            _scsCustomerView.SupportContract);
            Assert.AreEqual(cashIntegrator, _scsCustomerView.CashIntegrator);

            StringAssert.Matches(_scsCustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_scsCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_scsCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_scsCustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _scsCustomerView.CompanyName);
            Assert.AreEqual(po, _scsCustomerView.Po);
            Assert.AreEqual(adressAddition, _scsCustomerView.AdressAddition);
            Assert.AreEqual(region, _scsCustomerView.Region);
            Assert.AreEqual(streetName, _scsCustomerView.StreetName);
            Assert.AreEqual(zip, _scsCustomerView.Zip);
            Assert.AreEqual(city, _scsCustomerView.City);
            Assert.AreEqual(billingTenant, _scsCustomerView.Agency);
            Assert.AreEqual(language, _scsCustomerView.Language);
            Assert.AreEqual(country, _scsCustomerView.Country);
            Assert.AreEqual(email, _scsCustomerView.Email);
            Assert.AreEqual(telephone, _scsCustomerView.Telephone);
            Assert.AreEqual(mobile, _scsCustomerView.Mobile);
            Assert.AreEqual(fax, _scsCustomerView.Fax);
            Assert.AreEqual(web, _scsCustomerView.Web);

            _zebra.WebDriver.Url = "/Pages/Customer/CustomerEdit.aspx?CustomerId=" + custId;


            Assert.AreEqual(_customerName, _scsCustomerView.CustomerName);
            Assert.AreEqual(custId, _zebraCustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, _zebraCustomerView.CustomerName);
            Assert.AreEqual(supplier, _zebraCustomerView.Supplier);
            Assert.AreEqual(billingTenant, _zebraCustomerView.SbsBillingTenant);
            Assert.AreEqual(sbsCurrency, _zebraCustomerView.SbsCurrency);
            Assert.AreEqual(sapNumber, _zebraCustomerView.SapNumber);
            Assert.AreEqual(categoryCode, _zebraCustomerView.CategoryCode);
            Assert.AreEqual(supportContract,
                            _zebraCustomerView.SupportContract);
            Assert.AreEqual(cashIntegrator, _zebraCustomerView.CashIntegrator);

            StringAssert.Matches(_zebraCustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);

            try
            {
                StringAssert.Matches(_zebraCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
            }
            catch (AssertFailedException)
            {
            }

            StringAssert.Matches(_zebraCustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_zebraCustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(companyName, _zebraCustomerView.CompanyName);
            Assert.AreEqual(po, _zebraCustomerView.Po);
            Assert.AreEqual(adressAddition, _zebraCustomerView.AdressAddition);
            Assert.AreEqual(region, _zebraCustomerView.Region);
            Assert.AreEqual(streetName, _zebraCustomerView.StreetName);
            Assert.AreEqual(zip, _zebraCustomerView.Zip);
            Assert.AreEqual(city, _zebraCustomerView.City);
            Assert.AreEqual(billingTenant, _zebraCustomerView.Agency);
            Assert.AreEqual(language, _zebraCustomerView.Language);
            Assert.AreEqual(country, _zebraCustomerView.Country);
            Assert.AreEqual(email, _zebraCustomerView.Email);
            Assert.AreEqual(telephone, _zebraCustomerView.Telephone);
            Assert.AreEqual(mobile, _zebraCustomerView.Mobile);
            Assert.AreEqual(fax, _zebraCustomerView.Fax);
            Assert.AreEqual(web, _zebraCustomerView.Web);
        }
    }
}