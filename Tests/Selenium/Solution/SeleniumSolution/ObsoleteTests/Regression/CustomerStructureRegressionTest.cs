using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Common.Infotext;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Brand;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Regression
{
    [TestClass]
    public class CustomerStructureRegressionTest
    {
        private static string _terminalIdLocation;
        private static string _terminalIdCustomer;
        private static TestData.ValueObjects.Customer _customer;
        private static TestData.ValueObjects.Location _location;
        private static TestData.ValueObjects.Person _personOnCustomer;
        private static TestData.ValueObjects.Person _personOnLocation;
        private static TestData.ValueObjects.Mpd _mpd;
        private static TestData.ValueObjects.User _user;

        /* [ClassCleanup]
        public static void CleanupCustomerStructure()
        {
            DeleteCustomer();
            DeleteLocation();
            DeletePersons();
            DeleteTerminals();            
            DeleteMpd();            
            DeleteUser();            
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
            BrandSelect.Deselect("1161");

            BrandSelect.ConfirmButton().Click();

            AcquirerCreate.Remark = "SYR Contracts" + Factory.GenerateTestId();
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // BrandCreate.
        }

        private static void EditLocation()
        {
            _location = TestData.Factory.Location.Edit();
            Workflow.Location.Edit(_location);
            Testlogic.Location.Check(_location);

            Lobby.OpenLatestElement();
            Testlogic.Location.Check(_location);
        }

        private static void EditCustomer()
        {
            _customer = TestData.Factory.Customer.Edit();
            Workflow.Customer.Edit(_customer);
            Testlogic.Customer.Check(_customer);

            Lobby.OpenLatestElement();
            Testlogic.Customer.Check(_customer);
        }

        private static void CreateContactOnLocation()
        {
            LocationMenu.ContactCreate.Click();
            _personOnLocation = TestData.Factory.Person.Create();
            Workflow.Contact.Create(_personOnLocation);
            Testlogic.Contact.Check(_personOnLocation);

            Lobby.OpenLatestElement();
            Testlogic.Contact.Check(_personOnLocation);
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

            Lobby.OpenLatestElement();
            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual(_location.Contact.Language, BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(_location.CompanyName, LocationInfo.CompanyName);
        }

        private static void CreateLocationOnCustomer()
        {
            _location = TestData.Factory.Location.Create();
            Workflow.Location.Create(_location);
            Testlogic.Location.Check(_location);

            Lobby.OpenLatestElement();
            Testlogic.Location.Check(_location);
        }

        private static void CreateTerminalOnCustomer()
        {
            CustomerMenu.Customer.Click();
            CustomerMenu.TerminalCreate.Click();
            TerminalChooser.ArticleFilter = "1550";
            TerminalChooser.Article = "yomani AUTONOM, TCP/IP ep2 (DNS)";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();

            TerminalConfigCreate.ContinueButton.Click();
            TerminalConfigCreate.SaveButton.Click();

            Assert.IsTrue(BrandSelect.BrandTree().Displayed);
            TerminalMenu.Terminal.Click();
            _terminalIdCustomer = TerminalInfo.TerminalId;

            Lobby.OpenLatestElement();
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
            _personOnCustomer = TestData.Factory.Person.Create();
            Workflow.Contact.Create(_personOnCustomer);
            Testlogic.Contact.Check(_personOnCustomer);
            Lobby.OpenLatestElement();
            Testlogic.Contact.Check(_personOnCustomer);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToCustomerIsCreated()
        {
            Testlogic.Search.CustomerCanBeFoundByCustomerNumber(_customer.CustomerNumber);

            CustomerMenu.Contacts.Click();

            ContactList.First().Click();

            Testlogic.Contact.Check(_personOnCustomer);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void ContactToLocationIsCreated()
        {
            Testlogic.Search.LocationCanBeFoundByLocationName(_location.CompanyName);

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            Testlogic.Contact.Check(_personOnLocation);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void TerminalToLocationIsCreated()
        {
            Testlogic.Search.TerminalCanBeFoundById(_terminalIdLocation);

            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [Ignore]
        // [TestCategory("RegressionA")]
        public void BrandsOnTerminalAreCreated()
        {
            Testlogic.Search.TerminalCanBeFoundById(_terminalIdLocation);
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
            Testlogic.Search.CustomerCanBeFoundByCustomerNumber(_customer.CustomerNumber);

            CustomerMenu.AllTerminals.Click();
            TerminalList.First().Click();
            // TerminalList.Result(_terminalIdCustomer).Click();

            Assert.AreEqual(_terminalIdCustomer, TerminalInfo.TerminalId);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void CustomerIsCreated()
        {
            Testlogic.Search.CustomerCanBeFoundByCustomerName(_customer.CustomerName);
            Testlogic.Customer.Check(_customer);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void UserIsCreated()
        {
            Testlogic.Search.UserCanBeFoundByCustomerName(_user.UserName);
            Testlogic.User.Check(_user);
        }

        [TestMethod]
        [TestCategory("RegressionA")]
        public void LocationIsCreated()
        {
            Testlogic.Search.LocationCanBeFoundByLocationName(_location.CompanyName);

            Testlogic.Location.Check(_location);
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

            OpenTerminalOnLocation();
        }

        private static void OpenTerminalOnLocation()
        {
            Testlogic.Search.TerminalCanBeFoundById(_terminalIdLocation);
        }

        private static void OpenLocation()
        {
            Testlogic.Search.LocationCanBeFoundByLocationName(_location.CompanyName);
            Assert.AreEqual(_location.Guid, LocationView.Guid);
        }

        private static void CreateUser()
        {
            _user = TestData.Factory.User.Create();
            Workflow.User.Create(_user);

            Testlogic.User.Check(_user);
            Lobby.OpenLatestElement();
            Testlogic.User.Check(_user);
        }

        private static void OpenCustomer()
        {
            Testlogic.Search.CustomerCanBeFoundByCustomerNumber(_customer.CustomerNumber);
            Assert.AreEqual(_customer.CustomerNumber, CustomerView.CustomerNumber);
        }

        private static void CreateCustomer()
        {
            _customer = TestData.Factory.Customer.Create();
            Workflow.Customer.Create(_customer);
            Testlogic.Customer.Check(_customer);
            Lobby.OpenLatestElement();
            Testlogic.Customer.Check(_customer);
        }

        private static void CreateMpdOnCustomer()
        {
            _mpd = TestData.Factory.Mpd.Create();
            Workflow.Mpd.Create(_mpd);
            Testlogic.Mpd.Check(_mpd);

            Lobby.OpenLatestElement();
            Testlogic.Mpd.Check(_mpd);
        }

        private static void EditContactOnLocation()
        {
            ContactMenu.ContactEdit.Click();
            _personOnLocation = TestData.Factory.Person.Edit();
            Workflow.Contact.Edit(_personOnLocation);
            Testlogic.Contact.Check(_personOnLocation);

            Lobby.OpenLatestElement();
            Testlogic.Contact.Check(_personOnLocation);
        }

        private static void CreateInfotextOnLocation()
        {
            LocationMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfoText.Create("Location");
        }

        private static void CreateInfotextOnCustomer()
        {
            CustomerMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfoText.Create("Customer");
        }

        private static void CreateInfotextOnTerminal()
        {
            TerminalTextsPortlet.CreateInfotext.Click();
            InfoText.Create("Terminal");
        }
    }
}