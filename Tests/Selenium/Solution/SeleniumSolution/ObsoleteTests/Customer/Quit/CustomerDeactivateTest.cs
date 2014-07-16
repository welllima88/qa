using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Quit
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