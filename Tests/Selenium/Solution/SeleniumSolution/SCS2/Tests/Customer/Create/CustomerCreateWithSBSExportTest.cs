using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateWithSbsExportTest
    {
        private const int MillisecondsTimeout = 1000;
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static CustomerMenu _customerMenu;
        private static LobbyMenu _lobbyMenu;
        private static MenusTest _menusTests;
        private static Lobby _lobby;

        private long _dt;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _lobbyMenu = new LobbyMenu(_driver);
            _customerMenu = new CustomerMenu(_driver);
            _customerCreate = new CustomerCreate(_driver);
            _customerView = new CustomerView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _menusTests = new MenusTest();
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Default.aspx";
            _dt = DateTime.Now.Ticks; //timestamp for each test
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
        [TestCategory("SmokeTest")]
        public void CreateCustomerWithSbsAndMinimalAndSave()
        {
            _customerMenu.CustomerCreate.Click();

            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "CHF";
            _customerCreate.CustomerName = "SYR SBS Kunde" + _dt;

            _customerCreate.CompanyName = "SYR SBS Firma" + _dt;
            _customerCreate.StreetName = "SbsRoad. 201";
            _customerCreate.Zip = "8008";
            _customerCreate.City = "SBS";
            _customerCreate.SbsBillingTenant = "SIX Payment Services (Europe)";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("SYR SBS Kunde" + _dt, _customerView.CustomerName);
            string custId = _customerView.CustomerNumber;

            //check/read customerId

            Assert.AreEqual(custId, _customerView.CustomerNumber);
            Assert.AreEqual(custId, _customerView.SbsDebitNumber);

            StringAssert.Matches(_customerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);

            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);

            int retry = 4;
            do
            {
                try
                {
                    StringAssert.Matches(_customerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(MillisecondsTimeout);
                    //carefull
                    //_driver.Navigate().Refresh(); doesn't work proper, so this is better:
                    _customerMenu.Customer.Click();
                    retry--;
                }
            } while (retry > 0);

            Assert.AreEqual("SYR SBS Firma" + _dt, _customerView.CompanyName);
            Assert.AreEqual("SbsRoad. 201", _customerView.StreetNo);
            Assert.AreEqual("8008", _customerView.Zip);
            Assert.AreEqual("SBS", _customerView.City);
            Assert.AreEqual("CHF", _customerView.SbsCurrency);
        }
    }
}