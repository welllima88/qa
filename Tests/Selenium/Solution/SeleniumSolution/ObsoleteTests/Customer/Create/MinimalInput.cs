using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestFixture]
    public class MinimalInput
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

        [TestFixtureSetUp]
        public static void ClassInit()
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

        [Test]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, View.CustomerName);
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
        public void SapNumber()
        {
            Assert.AreEqual(" ", View.SapNumber);
        }

        [Test]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", View.CategoryCode);
        }

        [Test]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag",
                View.SupportContract);
        }

        [Test]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", View.CashIntegrator);
        }

        [Test]
        public void SbsDebitNumber()
        {
            StringAssert.IsMatch(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [Test]
        public void SbsAdressNumber()
        {
            StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [Test]
        public void Ep2MerchantId()
        {
            StringAssert.IsMatch(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
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
            Assert.AreEqual(_streetName, View.StreetNo);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual(_zip, View.Zip);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual(_city, View.City);
        }

        [Test]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", View.Agency);
        }

        [Test]
        [Ignore]
        public void Language()
        {
            Assert.AreEqual(_language, View.Language);
        }

        [Ignore]
        [Test]
        public void Country()
        {
            Assert.AreEqual(_country, View.Country);
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
            Assert.AreEqual("", View.Web);
        }

        [Test]
        public void MostRecent()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual(_custId, View.CustomerNumber);
        }
    }
}