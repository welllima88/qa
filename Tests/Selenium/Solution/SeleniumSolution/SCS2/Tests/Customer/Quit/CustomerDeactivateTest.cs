using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Customer;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
        }

        [TestMethod]
        public void DeactivateCustomerAndCancel()
        {
            CustomerMenu.CustomerDeactivate.Click();
            CustomerDeactivation.Cancel.Click();
            // StringAssert.DoesNotMatch(CustomerView.header,new RegExp("deactivated"));
        }
    }
}