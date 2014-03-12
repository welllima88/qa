﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Edit;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Brand;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;
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

            QA.Selenium.Extension.Worklow.Search.CustomerCanBeFoundByCustomerId(_customerNumber);
            CreateTerminalOnCustomer();

            QA.Selenium.Extension.Worklow.Search.CustomerCanBeFoundByCustomerName(_customerName);
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            EditCustomer();

            CreateLocationOnCustomer();

            CreateTerminalOnLocation();
            // CreateContractsOnTerminal();

            QA.Selenium.Extension.Worklow.Search.LocationCanBeFoundByLocationName(_locationName);
            Assert.AreEqual(_locationGuid, LocationView.Guid);

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

            ContractSelect.Select("1161");
            ContractSelect.Select("283");
            ContractSelect.Select("332");
            ContractSelect.Select("361");
            ContractSelect.Select("363");
            ContractSelect.Select("811");
            ContractSelect.DeSelect("1161");

            ContractSelect.ConfirmButton().Click();

            AcquirerCreate.Remark = "SYR Contracts" + TestLauncher.GenerateTestId();
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // ContractCreate.
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
            ContactCreateToCustomerTest.DoCreateContact();
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
            ContactCreateToCustomerTest.DoCreateContact();
            _contactCustomerName = ContactPersonView.FirstName;
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToCustomerIsCreated()
        {
            QA.Selenium.Extension.Worklow.Search.CustomerCanBeFoundByCustomerId(_customerNumber);

            CustomerMenu.Contacts.Click();

            ContactList.First().Click();

            Assert.AreEqual(_contactCustomerName, ContactPersonView.FirstName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToLocationIsCreated()
        {
            QA.Selenium.Extension.Worklow.Search.LocationCanBeFoundByLocationName(_locationName);

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            Assert.AreEqual(_contactLocationName, ContactPersonView.FirstName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void TerminalToLocationIsCreated()
        {
            QA.Selenium.Extension.Worklow.Search.TerminalCanBeFoundById(_terminalIdLocation);

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        [Ignore]
        public void ContractsOnTerminalAreCreated()
        {
            QA.Selenium.Extension.Worklow.Search.TerminalCanBeFoundById(_terminalIdLocation);

            StringAssert.Contains(BrandPortlet.Brand("283").Text, "[283]");
            StringAssert.Contains(BrandPortlet.Brand("332").Text, "[332]");
            StringAssert.Contains(BrandPortlet.Brand("361").Text, "[361]");
            StringAssert.Contains(BrandPortlet.Brand("363").Text, "[363]");
            StringAssert.Contains(BrandPortlet.Brand("811").Text, "[811]");
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void TerminalToCustomerIsCreated()
        {
            QA.Selenium.Extension.Worklow.Search.CustomerCanBeFoundByCustomerId(_customerNumber);

            CustomerMenu.AllTerminals.Click();
            TerminalList.First().Click();
            // TerminalList.Result(_terminalIdCustomer).Click();

            Assert.AreEqual(_terminalIdCustomer, TerminalInfo.TerminalId);
        }
    }
}