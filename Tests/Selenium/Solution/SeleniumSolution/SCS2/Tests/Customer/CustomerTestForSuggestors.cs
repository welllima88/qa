using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class CustomerTestForSuggestors
    {
        private static CustomerCreate _customerCreate;
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;
        private static Lobby _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _customerCreate = new CustomerCreate(_driver);
            _customerMenu = new CustomerMenu(_driver);
            _lobby = new Lobby(_driver);
        }


        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }


        [ClassCleanup]
        public static void ClassCleanup()
        {
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateCustomerOnlySuggesterAndCancelToCheckSuggestor()
        {
            _customerMenu.CustomerCreate.Click();
            _customerCreate.CustomerName = "Selenium Test will cancel for SUGGESTER";
            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.CancelButton.Click();
            Assert.IsTrue(_lobby.Headline.Displayed);
            Assert.IsTrue(_lobby.Menu.Customer.CustomerCreate.Displayed);
        }

        [TestMethod]
        public void CreateCustomerAndCancelToCheckSuggestor()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "CHF";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            _customerCreate.CustomerName = "SYR Sele Kunde A";

            _customerCreate.CompanyName = "";
            _customerCreate.StreetName = "";
            _customerCreate.Zip = "";
            _customerCreate.City = "";

            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.SaveButton.Click();
        }
    }
}