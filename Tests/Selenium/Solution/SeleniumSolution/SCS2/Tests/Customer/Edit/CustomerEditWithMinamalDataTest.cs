using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditWithMinamalDataTest
    {
        private static string _customerNumber;
        private static string _sbsDebitNumber;
        private static string _sbsAdressNumber;
        private static string _ep2MerchantId;
        private static string _segment;
        private static string _sbsCurrency;
        private static string _sbsBillingTenant;
        private static string _supplier;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=401858");

            _customerNumber = CustomerView.CustomerNumber;
            _sbsDebitNumber = CustomerView.SbsDebitNumber;
            _sbsAdressNumber = CustomerView.SbsAdressNumber;
            _ep2MerchantId = CustomerView.Ep2MerchantId;
            _segment = CustomerView.Segment;
            _sbsCurrency = CustomerView.SbsCurrency;
            _sbsBillingTenant = CustomerView.SbsBillingTenant;
            _supplier = CustomerView.Supplier;

            CustomerMenu.CustomerEdit.Click();

            CustomerEdit.CustomerName = "SYR Sele Kunde Minimal";
            CustomerEdit.CompanyName = "SYR Sele Firma Minimal";
            CustomerEdit.StreetNo = "Hardturmstr. 201";
            CustomerEdit.Po = "";
            CustomerEdit.SapNumber = "";
            CustomerEdit.Region = "";
            CustomerEdit.AdressAddition = "";
            CustomerEdit.Zip = "8021";
            CustomerEdit.City = "Zürich";

            CustomerEdit.Agency = "Keine Agentur";
            CustomerEdit.Language = "Deutsch [de]";
            CustomerEdit.Country = "Schweiz [CH]";
            CustomerEdit.Email = "";
            CustomerEdit.Telephone = "";
            CustomerEdit.Mobile = "";
            CustomerEdit.Fax = "";
            CustomerEdit.Web = "";

            CustomerEdit.SaveButton.Click();
        }

        [TestMethod]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
        }

        [TestMethod]
        public void CustomerNumberFormat()
        {
            StringAssert.Matches(_customerNumber, TestRegExpPatterns.CustomerNo);
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual("SYR Sele Kunde Minimal", CustomerView.CustomerName);
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
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, CustomerView.SbsDebitNumber);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, CustomerView.SbsAdressNumber);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag", CustomerView.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", CustomerView.CashIntegrator);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual("", CustomerView.SapNumber);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, CustomerView.Ep2MerchantId);
        }

        [TestMethod]
        public void Segment()
        {
            Assert.AreEqual(_segment, CustomerView.Segment);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", CustomerView.CategoryCode);
        }

        [TestMethod]
        public void SbsDebitorNo()
        {
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNoOpt()
        {
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Sele Firma Minimal", CustomerView.CompanyName);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(" ", CustomerView.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(" ", CustomerView.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(" ", CustomerView.Region);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Hardturmstr. 201", CustomerView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("8021", CustomerView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Zürich", CustomerView.City);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", CustomerView.Agency);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(" ", CustomerView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(" ", CustomerView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(" ", CustomerView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(" ", CustomerView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(" ", CustomerView.Web);
        }

        [TestMethod]
        [Ignore]
        public void LanguageEditCustomerWithMinimalAndSave()
        {
            Assert.AreEqual("Deutsch [de]", CustomerView.Language);
        }

        [TestMethod]
        [Ignore]
        public void Country()
        {
            Assert.AreEqual("Schweiz [CH]", CustomerView.Country);
        }
    }
}