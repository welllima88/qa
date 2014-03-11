using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Brand;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;
using SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Regression
{
    [TestClass]
    public class CustomerStructureRegressionTest
    {
        private static string _customerNumber;
        private static string _locationGuid;
        private static string _locationName;
        private static string _customerName;
        private static string _contactCustomerName;
        private static string _contactLocationName;
        private static string _terminalIdLocation;
        private static string _terminalIdCustomer;

        [ClassInitialize]
        public static void CreateCustomerStructure(TestContext testContext)
        {
            CreateCustomer();

            CreateContactOnCustomer();

            CustomerCanBeFoundByCustomerId();
            CreateTerminalOnCustomer();

            CustomerCanBeFoundByCustomerName();
            EditCustomer();

            CreateLocationOnCustomer();

            CreateTerminalOnLocation();
            // CreateContractsOnTerminal();

            LocationCanBeFoundByLocationName();
            EditLocation();
            CreateContactOnLocation();
        }

        /* [ClassCleanup]
        public static void CleanupCustomerStructure()
        {
            DeleteCustomer();

            DeleteLocation();
            
            DeleteContact();
            DeleteContact();

            DeleteTerminal();
            DeleteTerminal();
        }*/

        private static void CreateContractsOnTerminal()
        {
            BrandPortlet.NewBrandButton.Click();

            ChooseBrands();

            AcquirerCreate.Remark = "SYR Contracts" + TestLauncher.GenerateTestId();
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // ContractCreate.
        }

        private static void ChooseBrands()
        {
            ContractSelect.Select("1161");
            ContractSelect.Select("283");
            ContractSelect.Select("332");
            ContractSelect.Select("361");
            ContractSelect.Select("363");
            ContractSelect.Select("811");
            ContractSelect.DeSelect("1161");
            ContractSelect.ConfirmButton().Click();
        }

        private static void EditLocation()
        {
            LocationEditAndSaveTest.DoEditLocation();
            _locationName = LocationView.CompanyName;
        }

        private static void EditCustomer()
        {
            CustomerEditAndSaveTest.DoEditCustomer();
            _customerName = CustomerView.CustomerName;
        }

        private static void CreateContactOnLocation()
        {
            LocationMenu.ContactCreate.Click();
            ContactCreateTest.DoCreateContact();
            _contactLocationName = ContactPersonView.FirstName;
        }

        private static void CreateTerminalOnLocation()
        {
            LocationMenu.TerminalCreate.Click();
            TerminalChooser.ArticleFilter = "xentissimo MOBILE WLAN, TCP/IP";
            TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + TestLauncher.GenerateTestId();
            TerminalConfigCreate.ContinueButton.Click();

            TerminalConfigDetailsCreate.InstallRemark = "Install SYR Auto" + TestLauncher.GenerateTestId();
            TerminalConfigDetailsCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();
            _terminalIdLocation = TerminalInfo.TerminalId;
        }

        private static void CreateLocationOnCustomer()
        {
            LocationCreateTest.DoCreateLocation();
            _locationGuid = LocationView.Guid;
            _locationName = LocationView.CompanyName;
        }

        private static void CreateTerminalOnCustomer()
        {
            CustomerMenu.Customer.Click();
            CustomerMenu.TerminalCreate.Click();
            TerminalChooser.Article = "yomani AUTONOM, TCP/IP ep2 (DNS)";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + TestLauncher.GenerateTestId();
            TerminalConfigCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();
            _terminalIdCustomer = TerminalInfo.TerminalId;
        }

        private static void CreateCustomer()
        {
            CustomerCreateTest.DoCreateCustomer();
            _customerNumber = CustomerView.CustomerNumber;
            _customerName = CustomerView.CustomerName;
        }

        private static void CreateContactOnCustomer()
        {
            CustomerMenu.ContactCreate.Click();
            ContactCreateTest.DoCreateContact();
            _contactCustomerName = ContactPersonView.FirstName;
        }

        public static void CustomerCanBeFoundByCustomerId()
        {
            Find(_customerNumber);
            CustomerResult.Result().Click();

            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
        }

        private static void Find(string searchString)
        {
            QuickSearch.SearchField = searchString;
            QuickSearch.HitEnter();
        }

        public static void CustomerCanBeFoundByCustomerName()
        {
            Find(_customerName);
            CustomerResult.Result().Click();

            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
        }

        public static void LocationCanBeFoundByLocationName()
        {
            Find(_locationName);
            LocationResult.Result().Click();

            Assert.AreEqual(_locationGuid, LocationView.Guid);
            Assert.AreEqual(_locationName, LocationView.CompanyName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToCustomerIsCreated()
        {
            CustomerCanBeFoundByCustomerId();

            CustomerMenu.Contacts.Click();

            ContactList.First().Click();

            Assert.AreEqual(_contactCustomerName, ContactPersonView.FirstName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToLocationIsCreated()
        {
            LocationCanBeFoundByLocationName();

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            Assert.AreEqual(_contactLocationName, ContactPersonView.FirstName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void TerminalToLocationIsCreated()
        {
            TerminalCanBeFoundById();

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        [Ignore]
        public void ContractsOnTerminalAreCreated()
        {
            TerminalCanBeFoundById();

            StringAssert.Contains(BrandPortlet.Brand("283").Text, "[283]");
            StringAssert.Contains(BrandPortlet.Brand("332").Text, "[332]");
            StringAssert.Contains(BrandPortlet.Brand("361").Text, "[361]");
            StringAssert.Contains(BrandPortlet.Brand("363").Text, "[363]");
            StringAssert.Contains(BrandPortlet.Brand("811").Text, "[811]");
        }

        private static void TerminalCanBeFoundById()
        {
            Find(_terminalIdLocation);
            TerminalResult.First().Click();

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void TerminalToCustomerIsCreated()
        {
            CustomerCanBeFoundByCustomerId();

            CustomerMenu.AllTerminals.Click();
            TerminalList.First().Click();
            // TerminalList.Result(_terminalIdCustomer).Click();

            Assert.AreEqual(_terminalIdCustomer, TerminalInfo.TerminalId);
        }
    }
}