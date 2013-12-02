using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer
{
    public class CustomerTestForSuggestors
    {
        private static CustomerCreate CustomerCreate;
        private static CustomerMenu CustomerMenu;
        private static LobbyView LobbyView;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerCreate = new CustomerCreate();
            CustomerMenu = new CustomerMenu();
            LobbyView = new LobbyView();
        }

        [TestMethod]
        public void CreateCustomerOnlySuggesterAndCancelToCheckSuggestor()
        {
            CustomerMenu.CustomerCreate.Click();
            CustomerCreate.CustomerName = "Selenium Test will cancel for SUGGESTER";
            CustomerCreate.Language = "Deutsch [de]";
            CustomerCreate.Country = "Schweiz [CH]";
            CustomerCreate.CancelButton.Click();
            Assert.IsTrue(LobbyView.Headline.Displayed);
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
        }

        [TestMethod]
        public void CreateCustomerAndCancelToCheckSuggestor()
        {
            CustomerMenu.CustomerCreate.Click();

            CustomerCreate.Supplier = "SIX Payment Services AG";
            CustomerCreate.SbsCurrency = "CHF";
            CustomerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";
            CustomerCreate.CustomerName = "SYR Sele Kunde A";

            CustomerCreate.CompanyName = "";
            CustomerCreate.StreetNo = "";
            CustomerCreate.Zip = "";
            CustomerCreate.City = "";

            CustomerCreate.Language = "Deutsch [de]";
            CustomerCreate.Country = "Schweiz [CH]";
            CustomerCreate.SaveButton.Click();
        }
    }
}