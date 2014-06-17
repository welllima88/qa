using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension;
using Six.Scs.Tests.Selenium.Extension.TestData;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Customer;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithSbsExportTest
    {
        private const int WaitMilliseconds = 1000;

        private static string _dt;
        private static string _custId;
        private int _numberOfRetries;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _dt = Factory.GenerateTestId();

            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();

            CustomerCreate.Supplier = "SIX Payment Services AG";
            CustomerCreate.SbsCurrency = "CHF";
            CustomerCreate.CustomerName = "SYR SBS Kunde" + _dt;

            CustomerCreate.CompanyName = "SYR SBS Firma" + _dt;
            CustomerCreate.StreetNo = "SbsRoad. 201";
            CustomerCreate.Zip = "8008";
            CustomerCreate.City = "SBS";
            CustomerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";

            CustomerCreate.SaveButton.Click();
            _custId = CustomerView.CustomerNumber;
        }

        [TestInitialize]
        public void TestInit()
        {
            Assert.AreEqual("SYR SBS Kunde" + _dt, CustomerView.CustomerName);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsDebitorNumberGeneratedFromCustomerId()
        {
            Assert.AreEqual(_custId, CustomerView.SbsDebitNumber);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsAdressNumberGeneratedFromSbs()
        {
            _numberOfRetries = 4;
            int retry = _numberOfRetries;
            do
            {
                try
                {
                    StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(WaitMilliseconds);
                    //carefull
                    //_driver.Navigate().Refresh(); doesn't work proper, so this is better:
                    CustomerMenu.Customer.Click();
                    retry--;
                }
            } while (retry > 0);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsDebitorNumberCorrectFormat()
        {
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        [TestCategory("SBS"), TestCategory("Customer")]
        public void SbsAdressNumberCorrectFormat()
        {
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }
    }
}