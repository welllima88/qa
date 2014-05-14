using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Brand;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Infotext;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
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
        private static string _terminalIdLocation;
        private static string _terminalIdCustomer;
        private static CustomerData _customer;
        private static LocationData _location;
        private static ContactPersonData _personOnCustomer;
        private static ContactPersonData _personOnLocation;
        private static MpdData _mpd;
        private static UserData _user;

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

            // BrandSelect.Acquirer("SIX Payment Services").Brand("1161").Brand("877").Brand("1076").Select();
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
            _location = Factory.Location.Edit();
            LocationService.Edit(_location);
            LocationService.Check(_location);

            OpenLatestElement();
            LocationService.Check(_location);
        }

        private static void EditCustomer()
        {
            _customer = Factory.Customer.Edit();
            CustomerService.Edit(_customer);
            CustomerService.Check(_customer);

            OpenLatestElement();
            CustomerService.Check(_customer);
        }

        private static void CreateContactOnLocation()
        {
            LocationMenu.ContactCreate.Click();
            _personOnLocation = Factory.ContactPerson.Create();
            ContactService.Create(_personOnLocation);
            ContactService.Check(_personOnLocation);

            OpenLatestElement();
            ContactService.Check(_personOnLocation);
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

            OpenLatestElement();
            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual(_location.Contact.Language, BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(_location.CompanyName, LocationInfo.CompanyName);
        }

        private static void CreateLocationOnCustomer()
        {
            _location = Factory.Location.Create();
            LocationService.Create(_location);
            LocationService.Check(_location);

            OpenLatestElement();
            LocationService.Check(_location);
        }

        private static void CreateTerminalOnCustomer()
        {
            CustomerMenu.Customer.Click();
            CustomerMenu.TerminalCreate.Click();
            TerminalChooser.ArticleFilter = "1550";
            TerminalChooser.Article = "yomani AUTONOM, TCP/IP ep2 (DNS)";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();
            TerminalConfigCreate.SaveButton.Click();

            Assert.IsTrue(BrandSelect.BrandTree().Displayed);
            TerminalMenu.Terminal.Click();
            _terminalIdCustomer = TerminalInfo.TerminalId;

            OpenLatestElement();
            Assert.AreEqual(_terminalIdCustomer, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("yomani AUTONOM, TCP/IP ep2 (DNS)", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("weiss", BusinessViewpointPortlet.Color);

            Assert.AreEqual(_customer.Location.Contact.Language, BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(_customer.CustomerNumber, CustomerInfo.Number);
            Assert.AreEqual(_customer.CustomerName, CustomerInfo.Name);
        }

        private static void CreateContactOnCustomer()
        {
            CustomerMenu.ContactCreate.Click();
            _personOnCustomer = Factory.ContactPerson.Create();
            ContactService.Create(_personOnCustomer);
            ContactService.Check(_personOnCustomer);
            OpenLatestElement();
            ContactService.Check(_personOnCustomer);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToCustomerIsCreated()
        {
            SearchService.CustomerCanBeFoundByCustomerNumber(_customer.CustomerNumber);

            CustomerMenu.Contacts.Click();

            ContactList.First().Click();

            ContactService.Check(_personOnCustomer);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToLocationIsCreated()
        {
            SearchService.LocationCanBeFoundByLocationName(_location.CompanyName);

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            ContactService.Check(_personOnLocation);
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
            SearchService.CustomerCanBeFoundByCustomerNumber(_customer.CustomerNumber);

            CustomerMenu.AllTerminals.Click();
            TerminalList.First().Click();
            // TerminalList.Result(_terminalIdCustomer).Click();

            Assert.AreEqual(_terminalIdCustomer, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void CustomerIsCreated()
        {
            SearchService.CustomerCanBeFoundByCustomerName(_customer.CustomerName);
            CustomerService.Check(_customer);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        [Ignore]
        public void UserIsCreated()
        {
            SearchService.UserCanBeFoundByCustomerName(_user.UserName);
            UserService.Check(_user);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void LocationIsCreated()
        {
            SearchService.LocationCanBeFoundByLocationName(_location.CompanyName);

            LocationService.Check(_location);
        }

        [ClassInitialize]
        public static void ExecuteRegressiontest(TestContext testContext)
        {
            CreateCustomer();
            CreateContactOnCustomer();
            CreateTerminalOnCustomer();
            // TODO:
            // CreateBrandsOnTerminal();

            OpenCustomer();
            EditCustomer();

            CreateInfotextOnCustomer();
            CreateMpdOnCustomer();

            CreateLocationOnCustomer();

            CreateTerminalOnLocation();
            CreateInfotextOnTerminal();

            OpenLocation();
            EditLocation();
            CreateInfotextOnLocation();

            CreateContactOnLocation();

            EditContactOnLocation();

            OpenCustomer();
            CreateUser();
        }

        private static void OpenLocation()
        {
            SearchService.LocationCanBeFoundByLocationName(_location.CompanyName);
            Assert.AreEqual(_location.Guid, LocationView.Guid);
        }

        private static void CreateUser()
        {
            _user = Factory.User.Create();
            UserService.Create(_user);

            UserService.Check(_user);
            OpenLatestElement();
            UserService.Check(_user);
        }

        private static void OpenCustomer()
        {
            SearchService.CustomerCanBeFoundByCustomerNumber(_customer.CustomerNumber);
            Assert.AreEqual(_customer.CustomerNumber, CustomerView.CustomerNumber);
        }

        private static void CreateCustomer()
        {
            _customer = Factory.Customer.Create();
            CustomerService.Create(_customer);
            CustomerService.Check(_customer);
            OpenLatestElement();
            CustomerService.Check(_customer);
        }

        private static void CreateMpdOnCustomer()
        {
            _mpd = Factory.Mpd.Create();
            MpdService.Create(_mpd);
            MpdService.Check(_mpd);

            OpenLatestElement();
            MpdService.Check(_mpd);
        }

        private static void EditContactOnLocation()
        {
            ContactMenu.ContactEdit.Click();
            _personOnLocation = Factory.ContactPerson.Edit();
            ContactService.Edit(_personOnLocation);
            ContactService.Check(_personOnLocation);

            OpenLatestElement();
            ContactService.Check(_personOnLocation);
        }

        private static void CreateInfotextOnLocation()
        {
            LocationMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfoTextService.Create("Location");
        }

        private static void CreateInfotextOnCustomer()
        {
            CustomerMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfoTextService.Create("Customer");
        }

        private static void CreateInfotextOnTerminal()
        {
            TerminalTextsPortlet.CreateInfotext.Click();
            InfoTextService.Create("Terminal");
        }

        private static void OpenLatestElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}