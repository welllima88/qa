using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateWithActiveTerminalsTest
    {
        private static CustomerView _customerView;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
            _customerMenu = new CustomerMenu();
        }

        [TestMethod]
        public void DeactivateCustomerAndSave()
        {
            _customerMenu.CustomerDeactivate.Click();
        }
    }
}