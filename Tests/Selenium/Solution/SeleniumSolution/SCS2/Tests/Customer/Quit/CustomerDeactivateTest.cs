using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateTest
    {
        private static CustomerView CustomerView;
        private static CustomerDeactivation _customerDeactivation;
        private static CustomerMenu CustomerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerView = new CustomerView();

            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
            CustomerMenu = new CustomerMenu();
            _customerDeactivation = new CustomerDeactivation();
        }

        [TestMethod]
        public void DeactivateCustomerAndCancel()
        {
            CustomerMenu.CustomerDeactivate.Click();
            _customerDeactivation.Cancel.Click();
            // StringAssert.DoesNotMatch(CustomerView.header,new RegExp("deactivated"));
        }
    }
}