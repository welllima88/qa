using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateTest
    {
        private static CustomerView _customerView;
        private static CustomerDeactivation _customerDeactivation;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
            _customerMenu = new CustomerMenu();
            _customerDeactivation = new CustomerDeactivation();
        }

        [TestMethod]
        public void DeactivateCustomerAndCancel()
        {
            _customerMenu.CustomerDeactivate.Click();
            _customerDeactivation.Cancel.Click();
            // StringAssert.DoesNotMatch(_customerView.header,new RegExp("deactivated"));
        }
    }
}