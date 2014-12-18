using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Quit
{
    [TestFixture]
    public class CustomerDeactivateTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=405125");
        }

        [Test]
        public void DeactivateCustomerAndCancel()
        {
            CustomerMenu.CustomerDeactivate.Click();
            Deactivate.Cancel.Click();
            // StringAssert.DoesNotMatch(CustomerView.header,new RegExp("deactivated"));
        }
    }
}