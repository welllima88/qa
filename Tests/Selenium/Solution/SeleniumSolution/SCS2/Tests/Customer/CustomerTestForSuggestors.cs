using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer
{
    [TestClass]
    [Ignore]
    public class CustomerTestForSuggestors
    {
        private static CustomerCreate _customerCreate;
        private static CustomerMenu _customerMenu;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerCreate = new CustomerCreate();
            _customerMenu = new CustomerMenu();
            _lobby = new LobbyView();
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
            _customerCreate.StreetNo = "";
            _customerCreate.Zip = "";
            _customerCreate.City = "";

            _customerCreate.Language = "Deutsch [de]";
            _customerCreate.Country = "Schweiz [CH]";
            _customerCreate.SaveButton.Click();
        }
    }
}