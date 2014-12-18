using System.Text.RegularExpressions;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestFixture]
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

        [TestFixtureSetUp]
        public static void ClassInit()
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

        [Test]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, View.CustomerNumber);
        }

        [Test]
        public void CustomerNumberFormat()
        {
            StringAssert.IsMatch(_customerNumber, new Regex(TestRegExpPatterns.CustomerNo));
        }

        [Test]
        public void CustomerName()
        {
            Assert.AreEqual("SYR Sele Kunde Minimal", View.CustomerName);
        }

        [Test]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, View.Supplier);
        }

        [Test]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, View.SbsBillingTenant);
        }

        [Test]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, View.SbsCurrency);
        }

        [Test]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, View.SbsDebitNumber);
        }

        [Test]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, View.SbsAdressNumber);
        }

        [Test]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag", View.SupportContract);
        }

        [Test]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", View.CashIntegrator);
        }

        [Test]
        public void SapNumber()
        {
            Assert.AreEqual("", View.SapNumber);
        }

        [Test]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);
        }

        [Test]
        public void Segment()
        {
            Assert.AreEqual(_segment, View.Segment);
        }

        [Test]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", View.CategoryCode);
        }

        [Test]
        public void SbsDebitorNo()
        {
            StringAssert.IsMatch(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [Test]
        public void SbsAdressNoOpt()
        {
            StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [Test]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.IsMatch(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [Test]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Sele Firma Minimal", View.CompanyName);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual(" ", View.Po);
        }

        [Test]
        public void AdressAddition()
        {
            Assert.AreEqual(" ", View.AdressAddition);
        }

        [Test]
        public void Region()
        {
            Assert.AreEqual(" ", View.Region);
        }

        [Test]
        public void StreetNo()
        {
            Assert.AreEqual("Hardturmstr. 201", View.StreetNo);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual("8021", View.Zip);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual("Zürich", View.City);
        }

        [Test]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", View.Agency);
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual(" ", View.Email);
        }

        [Test]
        public void Telephone()
        {
            Assert.AreEqual(" ", View.Telephone);
        }

        [Test]
        public void Mobile()
        {
            Assert.AreEqual(" ", View.Mobile);
        }

        [Test]
        public void Fax()
        {
            Assert.AreEqual(" ", View.Fax);
        }

        [Test]
        public void Web()
        {
            Assert.AreEqual(" ", View.Web);
        }

        [Test]
        [Ignore]
        public void LanguageEditCustomerWithMinimalAndSave()
        {
            Assert.AreEqual("Deutsch [de]", View.Language);
        }

        [Test]
        [Ignore]
        public void Country()
        {
            Assert.AreEqual("Schweiz [CH]", View.Country);
        }
    }
}