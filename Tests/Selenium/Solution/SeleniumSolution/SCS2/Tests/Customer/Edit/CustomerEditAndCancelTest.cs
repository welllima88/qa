using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    [Ignore]
    public class CustomerEditAndCancel
    {
        private static CustomerEdit _customerEdit;
        private static CustomerView _customerView;
        private static CustomerMenu _customerMenu;

        private static string _custId;
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
        private static string _streetName;
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

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _customerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");

            _custId = _customerView.CustomerNumber;
            _customerName = _customerView.CustomerName;
            _supplier = _customerView.Supplier;

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
            _streetName = _customerView.StreetNo;
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

            _customerEdit.CustomerName = "SYR Sele Kunde AAA";

            _customerEdit.CompanyName = "SYR Sele Firma AAA";
            _customerEdit.StreetNo = "Hardturmstr. 2011";
            _customerEdit.Zip = "80222";
            _customerEdit.City = "Zürichhh";
            _customerEdit.Po = "PFO111";
            _customerEdit.AdressAddition = "Etage 333";
            _customerEdit.Region = "Reggg";
            _customerEdit.SapNumber = "4449";

            _customerEdit.Agency = "C01 Bellia Antoine";
            _customerEdit.Language = "Kroatisch [hr]";
            _customerEdit.Country = "Albanien [AL]";
            _customerEdit.Email = "marc.siegmund@six-group.commmm";
            _customerEdit.Telephone = "0031 58 399 623777";
            _customerEdit.Mobile = "0032 58 399 623777";
            _customerEdit.Fax = "0033 58 399 623777";
            _customerEdit.Web = "www.six-group.com/de-internnnn";

            _customerEdit.CancelButton.Click();
        }

        [TestMethod]
        public void EditCustomerAndCancel()
        {
            Assert.AreEqual(_custId, _customerView.CustomerNumber);
            Assert.AreEqual(_customerName, _customerView.CustomerName);
            Assert.AreEqual(_supplier, _customerView.Supplier);
            Assert.AreEqual(_sbsDebitNumber, _customerView.SbsDebitNumber);
            Assert.AreEqual(_sbsAdressNumber, _customerView.SbsAdressNumber);
            Assert.AreEqual(_sbsBillingTenant, _customerView.SbsBillingTenant);
            Assert.AreEqual(_sbsCurrency, _customerView.SbsCurrency);
            Assert.AreEqual(_sapNumber, _customerView.SapNumber);
            Assert.AreEqual(_segment, _customerView.Segment);
            Assert.AreEqual(_ep2MerchantId, _customerView.Ep2MerchantId);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual(_companyName, _customerView.CompanyName);
            Assert.AreEqual(_po, _customerView.Po);
            Assert.AreEqual(_adressAddition, _customerView.AdressAddition);
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