using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.Tests.Selenium.Tests.Customer.Quit
{
    [TestClass]
    public class CustomerDeactivateWithActiveTerminalsTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
        }

        [TestMethod]
        public void DeactivateCustomerAndSave()
        {
            CustomerMenu.CustomerDeactivate.Click();
        }
    }
}