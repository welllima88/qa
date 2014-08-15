using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestClass]
    public class MinamalData
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

            _customerNumber = View.CustomerNumber;
            _sbsDebitNumber = View.SbsDebitNumber;
            _sbsAdressNumber = View.SbsAdressNumber;
            _ep2MerchantId = View.Ep2MerchantId;
            _segment = View.Segment;
            _sbsCurrency = View.SbsCurrency;
            _sbsBillingTenant = View.SbsBillingTenant;
            _supplier = View.Supplier;

            CustomerMenu.CustomerEdit.Click();

            Selenium.Customer.Edit.CustomerName = "SYR Sele Kunde Minimal";
            Selenium.Customer.Edit.CompanyName = "SYR Sele Firma Minimal";
            Selenium.Customer.Edit.StreetNo = "Hardturmstr. 201";
            Selenium.Customer.Edit.Po = "";
            Selenium.Customer.Edit.SapNumber = "";
            Selenium.Customer.Edit.Region = "";
            Selenium.Customer.Edit.AdressAddition = "";
            Selenium.Customer.Edit.Zip = "8021";
            Selenium.Customer.Edit.City = "Zürich";

            Selenium.Customer.Edit.Agency = "Keine Agentur";
            Selenium.Customer.Edit.Language = "Deutsch [de]";
            Selenium.Customer.Edit.Country = "Schweiz [CH]";
            Selenium.Customer.Edit.Email = "";
            Selenium.Customer.Edit.Telephone = "";
            Selenium.Customer.Edit.Mobile = "";
            Selenium.Customer.Edit.Fax = "";
            Selenium.Customer.Edit.Web = "";

            Selenium.Customer.Edit.SaveButton.Click();
        }

        [TestMethod]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, View.CustomerNumber);
        }

        [TestMethod]
        public void CustomerNumberFormat()
        {
            StringAssert.Matches(_customerNumber, new Regex(TestRegExpPatterns.CustomerNo));
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual("SYR Sele Kunde Minimal", View.CustomerName);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, View.Supplier);
        }

        [TestMethod]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, View.SbsBillingTenant);
        }

        [TestMethod]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, View.SbsCurrency);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, View.SbsDebitNumber);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, View.SbsAdressNumber);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag", View.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", View.CashIntegrator);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual("", View.SapNumber);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);
        }

        [TestMethod]
        public void Segment()
        {
            Assert.AreEqual(_segment, View.Segment);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", View.CategoryCode);
        }

        [TestMethod]
        public void SbsDebitorNo()
        {
            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [TestMethod]
        public void SbsAdressNoOpt()
        {
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Sele Firma Minimal", View.CompanyName);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(" ", View.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(" ", View.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(" ", View.Region);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Hardturmstr. 201", View.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("8021", View.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Zürich", View.City);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", View.Agency);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(" ", View.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(" ", View.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(" ", View.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(" ", View.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(" ", View.Web);
        }

        [TestMethod]
        [Ignore]
        public void LanguageEditCustomerWithMinimalAndSave()
        {
            Assert.AreEqual("Deutsch [de]", View.Language);
        }

        [TestMethod]
        [Ignore]
        public void Country()
        {
            Assert.AreEqual("Schweiz [CH]", View.Country);
        }
    }
}