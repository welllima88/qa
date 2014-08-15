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

            Selenium.Customer.Create.Supplier = _supplier;
            Selenium.Customer.Create.CategoryCode = _categoryCode;
            Selenium.Customer.Create.CustomerName = _customerName;
            Selenium.Customer.Create.CompanyName = _companyName;
            Selenium.Customer.Create.StreetNo = _streetName;
            Selenium.Customer.Create.Zip = _zip;
            Selenium.Customer.Create.City = _city;
            Selenium.Customer.Create.Po = _po;
            Selenium.Customer.Create.AdressAddition = _adressAddition;
            Selenium.Customer.Create.Region = _region;
            Selenium.Customer.Create.SapNumber = _sapNumber;

            Selenium.Customer.Create.Agency = _agency;
            Selenium.Customer.Create.Language = _language;
            Selenium.Customer.Create.Country = _country;
            Selenium.Customer.Create.Email = _email;
            Selenium.Customer.Create.Telephone = _telephone;
            Selenium.Customer.Create.Mobile = _mobile;
            Selenium.Customer.Create.Fax = _fax;
            Selenium.Customer.Create.Web = _web;

            Selenium.Customer.Create.SaveButton.Click();
        }

        [TestMethod]
        public void CreateCoopDivisionCustomerAndSave()
        {
            Assert.AreEqual(_customerName, View.CustomerName);
            string custId = View.CustomerNumber;

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual(custId, View.CustomerNumber);
            Assert.AreEqual(_customerName, View.CustomerName);
            Assert.AreEqual(_supplier, View.Supplier);
            Assert.AreEqual(_sapNumber, View.SapNumber);
            Assert.AreEqual(_categoryCode, View.CategoryCode);

            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            Assert.AreEqual(_companyName, View.CompanyName);
            Assert.AreEqual(_po, View.Po);
            Assert.AreEqual(_adressAddition, View.AdressAddition);
            Assert.AreEqual(_region, View.Region);
            Assert.AreEqual(_streetName, View.StreetNo);
            Assert.AreEqual(_zip, View.Zip);
            Assert.AreEqual(_city, View.City);
            Assert.AreEqual(_agency, View.Agency);
            Assert.AreEqual(_language, View.Language);
            Assert.AreEqual(_country, View.Country);
            Assert.AreEqual(_email, View.Email);
            Assert.AreEqual(_telephone, View.Telephone);
            Assert.AreEqual(_mobile, View.Mobile);
            Assert.AreEqual(_fax, View.Fax);
            Assert.AreEqual(_web, View.Web);
        }
    }
}