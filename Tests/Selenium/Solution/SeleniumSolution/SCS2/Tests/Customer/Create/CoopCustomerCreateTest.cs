using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Customer;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CoopCustomerCreateTest
    {
        private static string _supplier;
        private static string _customerName;
        private static string _companyName;
        private static string _streetName;
        private static string _zip;
        private static string _city;
        private static string _po;
        private static string _adressAddition;
        private static string _categoryCode;
        private static string _region;
        private static string _sapNumber;
        private static string _agency;
        private static string _language;
        private static string _country;
        private static string _email;
        private static string _telephone;
        private static string _mobile;
        private static string _fax;
        private static string _web;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();

            _supplier = "Coop ep2";
            _categoryCode = "3663: HOTELES EL PRESIDENTE";
            _customerName = "SYR Coop Division Kunde";
            _companyName = "SYR Coop Firma";
            _streetName = "Pronto 1a";
            _zip = "8008";
            _city = "Zürich";
            _po = "COO2";
            _adressAddition = "TakeAway";
            _region = "ZH-W";
            _sapNumber = "2244";
            _agency = "SIX LUX";
            _language = "Französisch [fr]";
            _country = "Luxemburg [LU]";
            _email = "marc.siegmund@six-group.com/coop";
            _telephone = "00 61 58 399 6237";
            _mobile = "00 62 58 399 6237";
            _fax = "00 63 58 399 6237";
            _web = "www.six-group.com/coop";

            CustomerCreate.Supplier = _supplier;
            CustomerCreate.CategoryCode = _categoryCode;
            CustomerCreate.CustomerName = _customerName;
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
        public void CreateCoopDivisionCustomerAndSave()
        {
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
            string custId = CustomerView.CustomerNumber;

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual(custId, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
            Assert.AreEqual(_supplier, CustomerView.Supplier);
            Assert.AreEqual(_sapNumber, CustomerView.SapNumber);
            Assert.AreEqual(_categoryCode, CustomerView.CategoryCode);

            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(_companyName, CustomerView.CompanyName);
            Assert.AreEqual(_po, CustomerView.Po);
            Assert.AreEqual(_adressAddition, CustomerView.AdressAddition);
            Assert.AreEqual(_region, CustomerView.Region);
            Assert.AreEqual(_streetName, CustomerView.StreetNo);
            Assert.AreEqual(_zip, CustomerView.Zip);
            Assert.AreEqual(_city, CustomerView.City);
            Assert.AreEqual(_agency, CustomerView.Agency);
            Assert.AreEqual(_language, CustomerView.Language);
            Assert.AreEqual(_country, CustomerView.Country);
            Assert.AreEqual(_email, CustomerView.Email);
            Assert.AreEqual(_telephone, CustomerView.Telephone);
            Assert.AreEqual(_mobile, CustomerView.Mobile);
            Assert.AreEqual(_fax, CustomerView.Fax);
            Assert.AreEqual(_web, CustomerView.Web);
        }
    }
}