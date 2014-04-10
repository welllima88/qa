using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Edit;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Infotext;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Mpd;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Brand;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Infotext;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Mpd;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand;
using SIX.SCS.QA.Selenium.Extension.Worklow;

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

        private static void CreateBrandsOnTerminal()
        {
            BrandPortlet.NewBrandButton.Click();

            BrandSelect.Select("1161");
            BrandSelect.Select("283");
            BrandSelect.Select("332");
            BrandSelect.Select("361");
            BrandSelect.Select("363");
            BrandSelect.Select("811");
            BrandSelect.DeSelect("1161");

            BrandSelect.ConfirmButton().Click();

            AcquirerCreate.Remark = "SYR Contracts" + Factory.GenerateTestId();
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // BrandCreate.
        }

        private static void EditLocation()
        {
            LocationEditAndSaveTest.Edit();
            _locationName = LocationView.CompanyName;
            LocationEditAndSaveTest.Check();
        }

        private static void EditCustomer()
        {
            CustomerData c = Factory.Customer.SixCustomerEdit();
            CustomerService.Edit(c);
            _customerName = CustomerView.CustomerName;
            CustomerService.Check(c);
        }

        private static void CreateContactOnLocation()
        {
            LocationMenu.ContactCreate.Click();
            ContactCreateToCustomerTest.Create();
            _contactLocationName = ContactPersonView.FirstName;
        }

        private static void CreateTerminalOnLocation()
        {
            LocationMenu.TerminalCreate.Click();

            TerminalChooser.ArticleFilter = "xentissimo MOBILE WLAN, TCP/IP";
            TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();
            TerminalConfigCreate.ContinueButton.Click();

            TerminalConfigDetailsCreate.InstallRemark = "Install SYR Auto" + Factory.GenerateTestId();
            TerminalConfigDetailsCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();
            _terminalIdLocation = TerminalInfo.TerminalId;

            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual("Englisch [en]", BusinessViewpointPortlet.TerminalLanguage);
        }

        private static void CreateLocationOnCustomer()
        {
            LocationCreateTest.Create();
            _locationGuid = LocationView.Guid;
            _locationName = LocationView.CompanyName;
            LocationCreateTest.Check();
        }

        private static void CreateTerminalOnCustomer()
        {
            CustomerMenu.Customer.Click();
            CustomerMenu.TerminalCreate.Click();
            TerminalChooser.ArticleFilter = "1550";
            TerminalChooser.Article = "yomani AUTONOM, TCP/IP ep2 (DNS)";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();
            TerminalConfigCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();
            _terminalIdCustomer = TerminalInfo.TerminalId;

            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("yomani AUTONOM, TCP/IP ep2 (DNS)", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("weiss", BusinessViewpointPortlet.Color);
            Assert.AreEqual("Deutsch [de]", BusinessViewpointPortlet.TerminalLanguage);
        }

        private static void CreateContactOnCustomer()
        {
            CustomerMenu.ContactCreate.Click();
            ContactCreateToCustomerTest.Create();
            ContactCreateToCustomerTest.Check();
            _contactCustomerName = ContactPersonView.FirstName;
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToCustomerIsCreated()
        {
            SearchService.CustomerCanBeFoundByCustomerId(_customerNumber);

            CustomerMenu.Contacts.Click();

            ContactList.First().Click();

            Assert.AreEqual(_contactCustomerName, ContactPersonView.FirstName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToLocationIsCreated()
        {
            SearchService.LocationCanBeFoundByLocationName(_locationName);

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            Assert.AreEqual(_contactLocationName, ContactPersonView.FirstName);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void TerminalToLocationIsCreated()
        {
            SearchService.TerminalCanBeFoundById(_terminalIdLocation);

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [Ignore]
        // [TestCategory("RegressionA")]
        public void BrandsOnTerminalAreCreated()
        {
            SearchService.TerminalCanBeFoundById(_terminalIdLocation);
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
            SearchService.CustomerCanBeFoundByCustomerId(_customerNumber);

            CustomerMenu.AllTerminals.Click();
            TerminalList.First().Click();
            // TerminalList.Result(_terminalIdCustomer).Click();

            Assert.AreEqual(_terminalIdCustomer, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void CustomerIsCreated()
        {
            SearchService.CustomerCanBeFoundByCustomerId(_customerNumber);

            // CustomerCheck();
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void LocationIsCreated()
        {
            SearchService.LocationCanBeFoundByLocationName(_locationName);

            // LocationCheck();
        }

        [ClassInitialize]
        public static void ExecuteRegressiontest(TestContext testContext)
        {
            var c = Factory.Customer.SixCustomerNew();
            CustomerService.Create(c);
            _customerNumber = CustomerView.CustomerNumber;
            OpenLatestElement();
            CustomerService.Check(c);
            CreateContactOnCustomer();

            SearchService.CustomerCanBeFoundByCustomerId(_customerNumber);
            CreateTerminalOnCustomer();
            OpenLatestElement();

            SearchService.CustomerCanBeFoundByCustomerName(_customerName);
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            EditCustomer();
            OpenLatestElement();
            CreateInfotextOnCustomer();
            // CreateMpdOnCustomer();

            CreateLocationOnCustomer();
            OpenLatestElement();

            CreateTerminalOnLocation();
            OpenLatestElement();
            CreateInfotextOnTerminal();

            // TODO:
            // CreateBrandsOnTerminal();

            SearchService.LocationCanBeFoundByLocationName(_locationName);
            Assert.AreEqual(_locationGuid, LocationView.Guid);

            EditLocation();
            OpenLatestElement();
            CreateInfotextOnLocation();

            CreateContactOnLocation();
            OpenLatestElement();
            EditContactOnLocation();
        }

        private static void CreateMpdOnCustomer()
        {
            CustomerMenu.AllMpds.Click();

            MpdListView.CreateButton.Click();
            MpdCreateTest.Create();
            MpdCreateTest.Check();
        }

        private static void EditContactOnLocation()
        {
            ContactMenu.ContactEdit.Click();
            ContactEditTest.Edit();
            ContactEditTest.Check();
            _contactLocationName = ContactPersonView.FirstName;
        }

        private static void CreateInfotextOnLocation()
        {
            LocationMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfotextCreateTest.Create("Location");
        }

        private static void CreateInfotextOnCustomer()
        {
            // TODO: CustomerMenu.Infotexts.Click();
            CustomerMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfotextCreateTest.Create("Customer");
        }

        private static void CreateInfotextOnTerminal()
        {
            TerminalTextsPortlet.CreateInfotext.Click();
            InfotextCreateTest.Create("Terminal");
        }

        private static void OpenLatestElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}