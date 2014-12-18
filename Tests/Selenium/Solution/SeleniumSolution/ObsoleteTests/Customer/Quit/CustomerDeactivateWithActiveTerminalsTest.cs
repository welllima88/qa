using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Quit
{
    [TestFixture]
    public class CustomerDeactivateWithActiveTerminalsTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
        }

        [Test]
        public void DeactivateCustomerAndSave()
        {
            CustomerMenu.CustomerDeactivate.Click();
        }
    }
}