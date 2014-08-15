using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestClass]
    public class CustomerEditKeepsDataTest
    {
        private static string _customerName;
        private static string _supplier;
        private static string _sapNumber;
        private static string _ep2MerchantId;
        private static string _companyName;
        private static string _po;
        private static string _adressAddition;
        private static string _streetNo;
        private static string _zip;
        private static string _city;
        private static string _agency;
        private static string _language;
        private static string _country;
        private static string _email;
        private static string _telephone;
        private static string _mobile;
        private static string _fax;
        private static string _web;
        private static string _customerNumber;
        private static string _region;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/edit?customerId=401858");

            _customerNumber = View.CustomerNumber;
            _customerName = View.CustomerName;
            _supplier = View.Supplier;
            _region = View.Region;
            _sapNumber = View.SapNumber;
            _ep2MerchantId = View.Ep2MerchantId;
            _companyName = View.CompanyName;
            _po = View.Po;
            _adressAddition = View.AdressAddition;
            _streetNo = View.StreetNo;
            _zip = View.Zip;
            _city = View.City;
            _agency = View.Agency;
            _language = View.Language;
            _country = View.Country;
            _email = View.Email;
            _telephone = View.Telephone;
            _mobile = View.Mobile;
            _fax = View.Fax;
            _web = View.Web;

            View.EditButton.Click();
        }

        [TestMethod]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, Selenium.Customer.Edit.CustomerNumber);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, Selenium.Customer.Edit.Supplier);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, Selenium.Customer.Edit.Ep2MerchantId);
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, Selenium.Customer.Edit.CustomerName);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, Selenium.Customer.Edit.CompanyName);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetNo, Selenium.Customer.Edit.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, Selenium.Customer.Edit.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, Selenium.Customer.Edit.City);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, Selenium.Customer.Edit.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, Selenium.Customer.Edit.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(_region, Selenium.Customer.Edit.Region);
        }

        [TestMethod]
        public void SapNumberEditCustomerAndSave()
        {
            Assert.AreEqual(_sapNumber, Selenium.Customer.Edit.SapNumber);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual(_agency, Selenium.Customer.Edit.Agency);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual(_language, Selenium.Customer.Edit.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, Selenium.Customer.Edit.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, Selenium.Customer.Edit.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, Selenium.Customer.Edit.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, Selenium.Customer.Edit.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, Selenium.Customer.Edit.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, Selenium.Customer.Edit.Web);
        }
    }
}