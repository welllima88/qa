using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithMinimalInputTest
    {
        private static long _dt;
        private static string _custId;
        private static string _customerName;
        private static string _supplier;
        private static string _sbsCurrency;
        private static string _sbsBillingTenant;
        private static string _companyName;
        private static string _streetName;
        private static string _zip;
        private static string _city;
        private static string _language;
        private static string _country;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            _dt = DateTime.Now.Ticks; //timestamp for each test

            _customerName = "SYR Kunde" + _dt;
            _supplier = "SIX Payment Services AG";
            _sbsCurrency = "CHF";
            _sbsBillingTenant = "SIX Payment Services (Europe)";
            _companyName = "SYR Firma" + _dt;
            _streetName = "Hardturmstr. 201";
            _zip = "8021";
            _city = "Zürich";
            _language = "Deutsch [de]";
            _country = "Schweiz [CH]";

            CustomerMenu.CustomerCreate.Click();

            Selenium.Customer.Create.Supplier = _supplier;
            Selenium.Customer.Create.SbsCurrency = _sbsCurrency;
            Selenium.Customer.Create.SbsBillingTenant = _sbsBillingTenant;

            Selenium.Customer.Create.CustomerName = _customerName;

            Selenium.Customer.Create.CompanyName = _companyName;
            Selenium.Customer.Create.StreetNo = _streetName;
            Selenium.Customer.Create.Zip = _zip;
            Selenium.Customer.Create.City = _city;

            Selenium.Customer.Create.Language = _language;
            Selenium.Customer.Create.Country = _country;

            Selenium.Customer.Create.SaveButton.Click();
            _custId = View.CustomerNumber;
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, View.CustomerName);
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
        public void SapNumber()
        {
            Assert.AreEqual(" ", View.SapNumber);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", View.CategoryCode);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag",
                View.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", View.CashIntegrator);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
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
            Assert.AreEqual(_streetName, View.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, View.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, View.City);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", View.Agency);
        }

        [TestMethod]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_language, View.Language);
        }

        [Ignore]
        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, View.Country);
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
            Assert.AreEqual("", View.Web);
        }

        [TestMethod]
        public void MostRecent()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual(_custId, View.CustomerNumber);
        }
    }
}