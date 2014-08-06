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

            _customerNumber = CustomerView.CustomerNumber;
            _customerName = CustomerView.CustomerName;
            _supplier = CustomerView.Supplier;
            _region = CustomerView.Region;
            _sapNumber = CustomerView.SapNumber;
            _ep2MerchantId = CustomerView.Ep2MerchantId;
            _companyName = CustomerView.CompanyName;
            _po = CustomerView.Po;
            _adressAddition = CustomerView.AdressAddition;
            _streetNo = CustomerView.StreetNo;
            _zip = CustomerView.Zip;
            _city = CustomerView.City;
            _agency = CustomerView.Agency;
            _language = CustomerView.Language;
            _country = CustomerView.Country;
            _email = CustomerView.Email;
            _telephone = CustomerView.Telephone;
            _mobile = CustomerView.Mobile;
            _fax = CustomerView.Fax;
            _web = CustomerView.Web;

            CustomerView.EditButton.Click();
        }

        [TestMethod]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, CustomerEdit.CustomerNumber);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, CustomerEdit.Supplier);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, CustomerEdit.Ep2MerchantId);
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, CustomerEdit.CustomerName);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, CustomerEdit.CompanyName);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetNo, CustomerEdit.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, CustomerEdit.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, CustomerEdit.City);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, CustomerEdit.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, CustomerEdit.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(_region, CustomerEdit.Region);
        }

        [TestMethod]
        public void SapNumberEditCustomerAndSave()
        {
            Assert.AreEqual(_sapNumber, CustomerEdit.SapNumber);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual(_agency, CustomerEdit.Agency);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual(_language, CustomerEdit.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, CustomerEdit.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, CustomerEdit.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, CustomerEdit.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, CustomerEdit.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, CustomerEdit.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, CustomerEdit.Web);
        }
    }
}