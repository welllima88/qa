using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension;
using Six.Scs.Tests.Selenium.Extension.TestData;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Customer;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Extension.Worklow;

namespace Six.Scs.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateTest
    {
        private static CustomerData _c;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            _c = CustomerFactory.Create();
            CustomerService.Create(_c);
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
            Assert.AreEqual(_c.CustomerName, CustomerView.CustomerName);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Supplier()
        {
            Assert.AreEqual(_c.Supplier, CustomerView.Supplier);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_c.SbsBillingTenant, CustomerView.SbsBillingTenant);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsCurrency()
        {
            Assert.AreEqual(_c.SbsCurrency, CustomerView.SbsCurrency);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SapNumber()
        {
            Assert.AreEqual(_c.Location.SapNumber, CustomerView.SapNumber);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        [Ignore] //because it is like other suggestors not reliable test
        public void CategoryCode()
        {
            Assert.AreEqual(_c.CategoryCode, CustomerView.CategoryCode);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SupportContract()
        {
            Assert.AreEqual(_c.SupportContract,
                CustomerView.SupportContract);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CashIntegrator()
        {
            Assert.AreEqual(_c.CashIntegrator, CustomerView.CashIntegrator);
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
            Assert.AreEqual(_c.Location.Adress.Po, CustomerView.Po);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void AdressAddition()
        {
            Assert.AreEqual(_c.Location.Adress.AdressAddition, CustomerView.AdressAddition);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Region()
        {
            Assert.AreEqual(_c.Location.Adress.Region, CustomerView.Region);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void StreetNo()
        {
            Assert.AreEqual(_c.Location.Adress.StreetNo, CustomerView.StreetNo);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Zip()
        {
            Assert.AreEqual(_c.Location.Adress.Zip, CustomerView.Zip);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void City()
        {
            Assert.AreEqual(_c.Location.Adress.City, CustomerView.City);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Agency()
        {
            Assert.AreEqual(_c.Agency, CustomerView.Agency);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_c.Location.Contact.Language, CustomerView.Language);
        }

        [Ignore]
        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Country()
        {
            Assert.AreEqual(_c.Location.Adress.Country, CustomerView.Country);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Email()
        {
            Assert.AreEqual(_c.Location.Contact.Email, CustomerView.Email);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Telephone()
        {
            Assert.AreEqual(_c.Location.Contact.Telephone, CustomerView.Telephone);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Mobile()
        {
            Assert.AreEqual(_c.Location.Contact.Mobile, CustomerView.Mobile);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Fax()
        {
            Assert.AreEqual(_c.Location.Contact.Fax, CustomerView.Fax);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Web()
        {
            Assert.AreEqual(_c.Location.Contact.Web, CustomerView.Web);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Segment()
        {
            Assert.AreEqual(_c.Segment, CustomerView.Segment);
        }
    }
}