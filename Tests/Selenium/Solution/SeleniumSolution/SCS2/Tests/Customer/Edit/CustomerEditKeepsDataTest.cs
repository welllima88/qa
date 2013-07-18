using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditKeepsDataTest
    {
        private static CustomerEdit _customerEdit;
        private static CustomerView _customerView;
        private static CustomerMenu _customerMenu;

        private static string _customerName;
        private static string _supplier;
        private static string _sbsBillingTenant;
        private static string _sbsCurrency;
        private static string _sapNumber;
        private static string _sbsDebitNumber;
        private static string _sbsAdressNumber;
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
        private static string _segment;
        private static string _customerNumber;
        private static string _region;
        private static string _cashIntegrator;
        private static string _categoryCode;
        private static string _supportContract;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _customerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=401858");

            _customerNumber = _customerView.CustomerNumber;
            _customerName = _customerView.CustomerName;
            _supplier = _customerView.Supplier;
            _region = _customerView.Region;
            _cashIntegrator = _customerView.CashIntegrator;
            _categoryCode = _customerView.CategoryCode;
            _supportContract = _customerView.SupportContract;
            _sbsBillingTenant = _customerView.SbsBillingTenant;
            _sbsCurrency = _customerView.SbsCurrency;
            _sapNumber = _customerView.SapNumber;
            _sbsDebitNumber = _customerView.SbsDebitNumber;
            _sbsAdressNumber = _customerView.SbsAdressNumber;
            _segment = _customerView.Segment;
            _ep2MerchantId = _customerView.Ep2MerchantId;
            _companyName = _customerView.CompanyName;
            _po = _customerView.Po;
            _adressAddition = _customerView.AdressAddition;
            _streetNo = _customerView.StreetNo;
            _zip = _customerView.Zip;
            _city = _customerView.City;
            _agency = _customerView.Agency;
            _language = _customerView.Language;
            _country = _customerView.Country;
            _email = _customerView.Email;
            _telephone = _customerView.Telephone;
            _mobile = _customerView.Mobile;
            _fax = _customerView.Fax;
            _web = _customerView.Web;

            _customerMenu.CustomerEdit.Click();
        }

        [TestMethod]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, _customerEdit.CustomerNumber);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, _customerEdit.Supplier);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, _customerEdit.Ep2MerchantId);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, _customerEdit.SbsDebitNumber);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, _customerEdit.SbsAdressNumber);
        }

        [TestMethod]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, _customerEdit.SbsCurrency);
        }

        [TestMethod]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, _customerEdit.SbsBillingTenant);
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual(_customerName, _customerEdit.CustomerName);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, _customerEdit.CompanyName);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual(_streetNo, _customerEdit.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual(_zip, _customerEdit.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual(_city, _customerEdit.City);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(_po, _customerEdit.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(_adressAddition, _customerEdit.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(_region, _customerEdit.Region);
        }

        [TestMethod]
        public void SapNumberEditCustomerAndSave()
        {
            Assert.AreEqual(_sapNumber, _customerEdit.SapNumber);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual(_categoryCode, _customerEdit.CategoryCode);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual(_supportContract, _customerEdit.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual(_cashIntegrator, _customerEdit.CashIntegrator);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual(_agency, _customerEdit.Agency);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual(_language, _customerEdit.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual(_country, _customerEdit.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(_email, _customerEdit.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(_telephone, _customerEdit.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(_mobile, _customerEdit.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(_fax, _customerEdit.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(_web, _customerEdit.Web);
        }

        [TestMethod]
        public void Segment()
        {
            Assert.AreEqual(_segment, _customerEdit.Segment);
        }
    }
}