using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditWithMinamalDataTest
    {
        private static CustomerEdit _customerEdit;
        private static CustomerView _customerView;
        private static CustomerMenu _customerMenu;

        private static string _customerNumber;
        private static string _sbsDebitNumber;
        private static string _sbsAdressNumber;
        private static string _ep2MerchantId;
        private static string _segment;
        private static string _guid;
        private static string _sbsCurrency;
        private static string _sbsBillingTenant;
        private static string _supplier;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerEdit = new CustomerEdit();
            _customerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");

            _guid = _customerView.Guid;
            _customerNumber = _customerView.CustomerNumber;
            _sbsDebitNumber = _customerView.SbsDebitNumber;
            _sbsAdressNumber = _customerView.SbsAdressNumber;
            _ep2MerchantId = _customerView.Ep2MerchantId;
            _segment = _customerView.Segment;
            _sbsCurrency = _customerView.SbsCurrency;
            _sbsBillingTenant = _customerView.SbsBillingTenant;
            _supplier = _customerView.Supplier;

            _customerMenu.CustomerEdit.Click();

            _customerEdit.CustomerName = "SYR Sele Kunde Minimal";
            _customerEdit.CompanyName = "SYR Sele Firma Minimal";
            _customerEdit.StreetNo = "Hardturmstr. 201";
            _customerEdit.Po = "";
            _customerEdit.SapNumber = "";
            _customerEdit.CategoryCode = "(Keine Branche)";
            _customerEdit.Region = "";
            _customerEdit.AdressAddition = "";
            _customerEdit.Zip = "8021";
            _customerEdit.City = "Zürich";
            _customerEdit.SupportContract = "Kein Supportvertrag";
            _customerEdit.CashIntegrator = "Kein Kassenintegrator";

            _customerEdit.Agency = "Keine Agentur";
            _customerEdit.Language = "Deutsch [de]";
            _customerEdit.Country = "Schweiz [CH]";
            _customerEdit.Email = "";
            _customerEdit.Telephone = "";
            _customerEdit.Mobile = "";
            _customerEdit.Fax = "";
            _customerEdit.Web = "";

            _customerEdit.SaveButton.Click();
        }

        [TestMethod]
        public void Guid()
        {
            Assert.AreEqual(_guid, _customerView.Guid);
        }

        [TestMethod]
        public void CustomerNumber()
        {
            Assert.AreEqual(_customerNumber, _customerView.CustomerNumber);
        }

        [TestMethod]
        public void CustomerNumberFormat()
        {
            StringAssert.Matches(_customerNumber, TestRegExpPatterns.CustomerNo);
        }

        [TestMethod]
        public void GuidFormat()
        {
            StringAssert.Matches(_guid, TestRegExpPatterns.Guid);
        }

        [TestMethod]
        public void CustomerName()
        {
            Assert.AreEqual("SYR Sele Kunde Minimal", _customerView.CustomerName);
        }

        [TestMethod]
        public void Supplier()
        {
            Assert.AreEqual(_supplier, _customerView.Supplier);
        }

        [TestMethod]
        public void SbsBillingTenant()
        {
            Assert.AreEqual(_sbsBillingTenant, _customerView.SbsBillingTenant);
        }

        [TestMethod]
        public void SbsCurrency()
        {
            Assert.AreEqual(_sbsCurrency, _customerView.SbsCurrency);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            Assert.AreEqual(_sbsDebitNumber, _customerView.SbsDebitNumber);
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            Assert.AreEqual(_sbsAdressNumber, _customerView.SbsAdressNumber);
        }

        [TestMethod]
        public void SupportContract()
        {
            Assert.AreEqual("Kein Supportvertrag", _customerView.SupportContract);
        }

        [TestMethod]
        public void CashIntegrator()
        {
            Assert.AreEqual("Kein Kassenintegrator", _customerView.CashIntegrator);
        }

        [TestMethod]
        public void SapNumber()
        {
            Assert.AreEqual("", _customerView.SapNumber);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, _customerView.Ep2MerchantId);
        }

        [TestMethod]
        public void Segment()
        {
            Assert.AreEqual(_segment, _customerView.Segment);
        }

        [TestMethod]
        public void CategoryCode()
        {
            Assert.AreEqual("(Keine Branche)", _customerView.CategoryCode);
        }

        [TestMethod]
        public void SbsDebitorNo()
        {
            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNoOpt()
        {
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(_customerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Sele Firma Minimal", _customerView.CompanyName);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual(" ", _customerView.Po);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual(" ", _customerView.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual(" ", _customerView.Region);
        }

        [TestMethod]
        public void StreetNo()
        {
            Assert.AreEqual("Hardturmstr. 201", _customerView.StreetNo);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("8021", _customerView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Zürich", _customerView.City);
        }

        [TestMethod]
        public void Agency()
        {
            Assert.AreEqual("Keine Agentur", _customerView.Agency);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual(" ", _customerView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual(" ", _customerView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual(" ", _customerView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual(" ", _customerView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual(" ", _customerView.Web);
        }

        [TestMethod]
        [Ignore]
        public void LanguageEditCustomerWithMinimalAndSave()
        {
            Assert.AreEqual("Deutsch [de]", _customerView.Language);
        }

        [TestMethod]
        [Ignore]
        public void Country()
        {
            Assert.AreEqual("Schweiz [CH]", _customerView.Country);
        }
    }
}