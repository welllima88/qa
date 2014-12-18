using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Create
{
    [TestFixture]
    public class SbsExport
    {
        private const int WaitMilliseconds = 1000;

        private static string _dt;
        private static string _custId;
        private int _numberOfRetries;

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            _dt = Factory.GenerateTestId();

            TestDirector.Navigate();

            CustomerMenu.CustomerCreate.Click();

            Selenium.Customer.Create.Supplier = "SIX Payment Services AG";
            Selenium.Customer.Create.SbsCurrency = "CHF";
            Selenium.Customer.Create.CustomerName = "SYR SBS Kunde" + _dt;

            Selenium.Customer.Create.CompanyName = "SYR SBS Firma" + _dt;
            Selenium.Customer.Create.StreetNo = "SbsRoad. 201";
            Selenium.Customer.Create.Zip = "8008";
            Selenium.Customer.Create.City = "SBS";
            Selenium.Customer.Create.SbsBillingTenant = "SIX Payment Services (Europe)";

            Selenium.Customer.Create.SaveButton.Click();
            _custId = View.CustomerNumber;
        }

        [SetUp]
        public void TestInit()
        {
            Assert.AreEqual("SYR SBS Kunde" + _dt, View.CustomerName);
        }

        [Test]
        [Category("SBS"), Category("Customer")]
        public void SbsDebitorNumberGeneratedFromCustomerId()
        {
            Assert.AreEqual(_custId, View.SbsDebitNumber);
        }

        [Test]
        [Category("SBS"), Category("Customer")]
        public void SbsAdressNumberGeneratedFromSbs()
        {
            _numberOfRetries = 4;
            int retry = _numberOfRetries;
            do
            {
                try
                {
                    StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNo));
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

        [Test]
        [Category("SBS"), Category("Customer")]
        public void SbsDebitorNumberCorrectFormat()
        {
            StringAssert.IsMatch(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [Test]
        [Category("SBS"), Category("Customer")]
        public void SbsAdressNumberCorrectFormat()
        {
            StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }
    }
}