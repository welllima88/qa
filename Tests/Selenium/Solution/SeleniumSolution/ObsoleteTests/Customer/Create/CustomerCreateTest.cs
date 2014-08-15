using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestClass]
    public class CustomerCreateTest
    {
        private static TestData.ValueObjects.Customer _c;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            _c = TestData.Factory.Customer.Create();
            Workflow.Customer.Create(_c);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CustomerNumber()
        {
            StringAssert.Matches(View.CustomerNumber, new Regex(TestRegExpPatterns.CustomerNo));
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CustomerName()
        {
            Assert.AreEqual(_c.CustomerName, View.CustomerName);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Supplier()
        {
            Assert.AreEqual(_c.Supplier, View.Supplier);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_c.SbsBillingTenant, View.SbsBillingTenant);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsCurrency()
        {
            Assert.AreEqual(_c.SbsCurrency, View.SbsCurrency);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SapNumber()
        {
            Assert.AreEqual(_c.Location.SapNumber, View.SapNumber);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        [Ignore] //because it is like other suggestors not reliable test
        public void CategoryCode()
        {
            Assert.AreEqual(_c.CategoryCode, View.CategoryCode);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SupportContract()
        {
            Assert.AreEqual(_c.SupportContract,
                View.SupportContract);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void CashIntegrator()
        {
            Assert.AreEqual(_c.CashIntegrator, View.CashIntegrator);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Ep2MerchantId()
        {
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Po()
        {
            Assert.AreEqual(_c.Location.Adress.Po, View.Po);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void AdressAddition()
        {
            Assert.AreEqual(_c.Location.Adress.AdressAddition, View.AdressAddition);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Region()
        {
            Assert.AreEqual(_c.Location.Adress.Region, View.Region);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void StreetNo()
        {
            Assert.AreEqual(_c.Location.Adress.StreetNo, View.StreetNo);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Zip()
        {
            Assert.AreEqual(_c.Location.Adress.Zip, View.Zip);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void City()
        {
            Assert.AreEqual(_c.Location.Adress.City, View.City);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Agency()
        {
            Assert.AreEqual(_c.Agency, View.Agency);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_c.Location.Contact.Language, View.Language);
        }

        [Ignore]
        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Country()
        {
            Assert.AreEqual(_c.Location.Adress.Country, View.Country);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Email()
        {
            Assert.AreEqual(_c.Location.Contact.Email, View.Email);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Telephone()
        {
            Assert.AreEqual(_c.Location.Contact.Telephone, View.Telephone);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Mobile()
        {
            Assert.AreEqual(_c.Location.Contact.Mobile, View.Mobile);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Fax()
        {
            Assert.AreEqual(_c.Location.Contact.Fax, View.Fax);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Web()
        {
            Assert.AreEqual(_c.Location.Contact.Web, View.Web);
        }

        [TestMethod]
        [TestCategory("Customer"), TestCategory("Create")]
        public void Segment()
        {
            Assert.AreEqual(_c.Segment, View.Segment);
        }
    }
}