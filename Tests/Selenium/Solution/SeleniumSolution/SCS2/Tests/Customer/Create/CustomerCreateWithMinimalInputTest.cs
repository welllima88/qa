using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
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

            CustomerCreate.Supplier = _supplier;
            CustomerCreate.SbsCurrency = _sbsCurrency;
            CustomerCreate.SbsBillingTenant = _sbsBillingTenant;

            CustomerCreate.CustomerName = _customerName;

            CustomerCreate.CompanyName = _companyName;
            CustomerCreate.StreetNo = _streetName;
            CustomerCreate.Zip = _zip;
            CustomerCreate.City = _city;

            CustomerCreate.Language = _language;
            CustomerCreate.Country = _country;

            CustomerCreate.SaveButton.Click();
            _custId = CustomerView.CustomerNumber;
        }

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate();
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
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
            Assert.AreEqual(" ", CustomerView.SapNumber);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", CustomerView.CategoryCode);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag",
                            CustomerView.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", CustomerView.CashIntegrator);
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
            Assert.AreEqual("Keine Agentur", CustomerView.Agency);
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
            Assert.AreEqual("", CustomerView.Web);
        }

        [TestMethod]
        public void MostRecent()
        {
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(_custId, CustomerView.CustomerNumber);
        }
    }
}