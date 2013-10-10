using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateWithActiveTerminalsTest
    {
        private static CustomerView CustomerView;
        private static CustomerMenu CustomerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
            CustomerMenu = new CustomerMenu();
        }

        [TestMethod]
        public void DeactivateCustomerAndSave()
        {
            CustomerMenu.CustomerDeactivate.Click();
        }
    }
}