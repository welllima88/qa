using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CoopCustomerCreateTest
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static CustomerMenu _customerMenu;
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
            _customerMenu = new CustomerMenu();
            _customerCreate = new CustomerCreate();
            _customerView = new CustomerView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();

            TestLauncher.Navigate("");

            _customerMenu.CustomerCreate.Click();

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

            _customerCreate.Supplier = _supplier;
            _customerCreate.CategoryCode = _categoryCode;
            _customerCreate.CustomerName = _customerName;
            _customerCreate.CompanyName = _companyName;
            _customerCreate.StreetNo = _streetName;
            _customerCreate.Zip = _zip;
            _customerCreate.City = _city;
            _customerCreate.Po = _po;
            _customerCreate.AdressAddition = _adressAddition;
            _customerCreate.Region = _region;
            _customerCreate.SapNumber = _sapNumber;

            _customerCreate.Agency = _agency;
            _customerCreate.Language = _language;
            _customerCreate.Country = _country;
            _customerCreate.Email = _email;
            _customerCreate.Telephone = _telephone;
            _customerCreate.Mobile = _mobile;
            _customerCreate.Fax = _fax;
            _customerCreate.Web = _web;

            _customerCreate.SaveButton.Click();
        }

        [TestMethod]
        public void CreateCoopDivisionCustomerAndSave()
        {
            Assert.AreEqual(_customerName, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(_customerName, _customerView.CustomerName);
            Assert.AreEqual(_supplier, _customerView.Supplier);
            Assert.AreEqual(_sapNumber, _customerView.SapNumber);
            Assert.AreEqual(_categoryCode, _customerView.CategoryCode);

            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(_companyName, _customerView.CompanyName);
            Assert.AreEqual(_po, _customerView.Po);
            Assert.AreEqual(_adressAddition, _customerView.AdressAddition);
            Assert.AreEqual(_region, _customerView.Region);
            Assert.AreEqual(_streetName, _customerView.StreetNo);
            Assert.AreEqual(_zip, _customerView.Zip);
            Assert.AreEqual(_city, _customerView.City);
            Assert.AreEqual(_agency, _customerView.Agency);
            Assert.AreEqual(_language, _customerView.Language);
            Assert.AreEqual(_country, _customerView.Country);
            Assert.AreEqual(_email, _customerView.Email);
            Assert.AreEqual(_telephone, _customerView.Telephone);
            Assert.AreEqual(_mobile, _customerView.Mobile);
            Assert.AreEqual(_fax, _customerView.Fax);
            Assert.AreEqual(_web, _customerView.Web);
        }
    }
}