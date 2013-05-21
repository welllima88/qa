using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateAndCancelTest
    {
        private static CustomerCreate _customerCreate;
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _customerMenu = new CustomerMenu(_driver);
            _customerCreate = new CustomerCreate(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Default.aspx";
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _customerMenu.CustomerDeactivate.Click();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateCustomerAndCancel()
        {
            _customerMenu.CustomerCreate.Click();
            _customerCreate.CustomerName = "Selenium Test will cancel";
            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsBillingTenant = "SIX Payment Services AG";
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "5555";
            _customerCreate.City = "Zürich";
            _customerCreate.SbsCurrency = "EUR";

            _customerCreate.CancelButton.Click();
            // ??:
            Assert.AreEqual("Lobby",
                            _driver.FindElement(By.CssSelector("span#ctl00_bodyContentPlaceHolder_lblTitle>h1")).Text);
        }
    }
}