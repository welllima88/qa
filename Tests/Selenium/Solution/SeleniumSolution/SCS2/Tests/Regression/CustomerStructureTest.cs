using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;
using SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Regression
{
    [TestClass]
    public class CustomerStructureTest
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
        public static void ClassInit(TestContext testContext)
        {
            CreateCustomer();

            CreateContactOnCustomer();

            CustomerCanBeFoundByCustomerId();
            CreateTerminalOnCustomer();

            CustomerCanBeFoundByCustomerName();
            EditCustomer();

            CreateLocationOnCustomer();

            CreateTerminalOnLocation();

            LocationCanBeFoundByLocationName();
            EditLocation();
            CreateContactOnLocation();
        }

        private static void EditLocation()
        {
            LocationEditAndSaveTest.DoEditLocation();
        }

        private static void EditCustomer()
        {
            CustomerEditAndSaveTest.DoEditCustomer();
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
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
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
        public void ContactToCustomerIsCreated()
        {
            CustomerCanBeFoundByCustomerId();

            CustomerMenu.Contacts.Click();

            ContactList.First().Click();

            Assert.AreEqual(_contactCustomerName, ContactPersonView.FirstName);
        }

        [TestMethod]
        public void ContactToLocationIsCreated()
        {
            LocationCanBeFoundByLocationName();

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            Assert.AreEqual(_contactLocationName, ContactPersonView.FirstName);
        }

        [TestMethod]
        public void TerminalToLocationIsCreated()
        {
            TerminalCanBeFoundById();

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        private static void TerminalCanBeFoundById()
        {
            Find(_terminalIdLocation);
            TerminalResult.First().Click();

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        [TestMethod]
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