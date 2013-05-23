using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class MultipleCustomerCreateTest
    {
        private const int NumberOfThreads = 5;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
        }

        [TestInitialize]
        public void TestInit()
        {
            //before first test-method starts            
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished            
        }

        public void MultiBrowserSessionTest()
        {
            RunMultiBrowser();
        }

        [TestMethod]
        public void RunMultiBrowser()
        {
            int no = NumberOfThreads;
            Thread browserInstance;
            while (no > 0)
            {
                var customerCreateAndCancelTest = new CustomerCreateAndCancelTest();
//                customerCreateTest.
                browserInstance = new Thread(customerCreateAndCancelTest.CreateCustomerAndCancel);
                browserInstance.Start();
                no--;
            }
        }

        [TestMethod]
        public void CreateCustomerAndCancel()
        {
            var tList = new List<Thread>(NumberOfThreads);
            for (int i = 0; i < NumberOfThreads; i++)
            {
                var browserInstance = new Thread(EnterValidCustomerDataAndCancel);
                tList.Add(browserInstance);
                browserInstance.Start();
            }
            foreach (Thread thread in tList)
                thread.Join();
        }

        public void EnterValidCustomerDataAndCancel()
        {
            var tb = new ScsPlatinTestDirector();
            IWebDriverAdapter driver = tb.DefaultTestSetup();
            var customerMenu = new CustomerMenu(driver);
            var customerCreate = new CustomerCreate(driver);

            customerMenu.CustomerCreate.Click();
            customerCreate.CustomerName = "Selenium Test will cancel";
            customerCreate.Supplier = "SIX Payment Services AG";
            customerCreate.SbsBillingTenant = "SIX Payment Services AG";
            customerCreate.StreetName = "Hardturmstr. 201";
            customerCreate.Zip = "5555";
            customerCreate.City = "Zürich";
            customerCreate.SbsCurrency = "EUR";

            customerCreate.CancelButton.Click();
            Assert.IsTrue(customerMenu.CustomerCreate.Displayed);

            tb.ShutDownTest();
        }
    }
}