using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateWithActiveTerminalsTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
        }

        [TestMethod]
        public void DeactivateCustomerAndSave()
        {
            CustomerMenu.CustomerDeactivate.Click();
        }
    }
}