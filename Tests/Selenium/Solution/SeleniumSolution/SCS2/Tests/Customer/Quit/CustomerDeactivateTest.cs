using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Quit
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