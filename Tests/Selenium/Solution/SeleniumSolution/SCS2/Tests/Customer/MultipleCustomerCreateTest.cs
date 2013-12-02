using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer
{
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
        //TODO probably not working
        public void RunMultiBrowser()
        {
            int no = NumberOfThreads;
            Thread browserInstance;
            while (no > 0)
            {
                var customerCreateAndCancelTest = new CustomerCreateTest();
//                customerCreateTest.
                browserInstance = new Thread(customerCreateAndCancelTest.AdressAddition);
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
            // TODO: not Working
            IWebDriverAdapter driver = TestDirector.PrepareBrowser();

            CustomerMenu.CustomerCreate.Click();
            CustomerCreate.CustomerName = "Selenium Test will cancel";
            CustomerCreate.Supplier = "SIX Payment Services AG";
            CustomerCreate.SbsBillingTenant = "SIX Payment Services AG";
            CustomerCreate.StreetNo = "Hardturmstr. 201";
            CustomerCreate.Zip = "5555";
            CustomerCreate.City = "Zürich";
            CustomerCreate.SbsCurrency = "EUR";

            CustomerCreate.CancelButton.Click();
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);

            TestDirector.ShutDownBrowser();
        }
    }
}