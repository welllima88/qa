using NUnit.Framework;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
{
    [TestFixture]
    public class KeepsData
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

        [TestFixtureSetUp]
        public static void ClassInit()
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

        [Test]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, Selenium.Customer.Edit.CustomerNumber);
        }

        [Test]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, Selenium.Customer.Edit.Supplier);
        }

        [Test]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, Selenium.Customer.Edit.Ep2MerchantId);
        }

        [Test]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, Selenium.Customer.Edit.CustomerName);
        }

        [Test]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, Selenium.Customer.Edit.CompanyName);
        }

        [Test]
        public void StreetNo()
        {
            Assert.AreEqual(_streetNo, Selenium.Customer.Edit.StreetNo);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual(_zip, Selenium.Customer.Edit.Zip);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual(_city, Selenium.Customer.Edit.City);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual(_po, Selenium.Customer.Edit.Po);
        }

        [Test]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, Selenium.Customer.Edit.AdressAddition);
        }

        [Test]
        public void Region()
        {
            Assert.AreEqual(_region, Selenium.Customer.Edit.Region);
        }

        [Test]
        public void SapNumberEditCustomerAndSave()
        {
            Assert.AreEqual(_sapNumber, Selenium.Customer.Edit.SapNumber);
        }

        [Test]
        public void Agency()
        {
            Assert.AreEqual(_agency, Selenium.Customer.Edit.Agency);
        }

        [Test]
        public void Language()
        {
            Assert.AreEqual(_language, Selenium.Customer.Edit.Language);
        }

        [Test]
        public void Country()
        {
            Assert.AreEqual(_country, Selenium.Customer.Edit.Country);
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual(_email, Selenium.Customer.Edit.Email);
        }

        [Test]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, Selenium.Customer.Edit.Telephone);
        }

        [Test]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, Selenium.Customer.Edit.Mobile);
        }

        [Test]
        public void Fax()
        {
            Assert.AreEqual(_fax, Selenium.Customer.Edit.Fax);
        }

        [Test]
        public void Web()
        {
            Assert.AreEqual(_web, Selenium.Customer.Edit.Web);
        }
    }
}