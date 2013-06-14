using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMinimalInputAndSbsExportAndSave
    {
        private const int MillisecondsTimeout = 1000;
        private static LocationView _locationView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static LocationCreate _locationCreate;
        private static LocationMenu _locationMenu;
        private static CustomerMenu _customerMenu;
        private static MenusTest _menusTests;
        private static CustomerView _customerView;
        private static LobbyView _lobby;

        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _customerMenu = new CustomerMenu(_driver);
            _customerView = new CustomerView(_driver);
            _locationMenu = new LocationMenu(_driver);
            _locationCreate = new LocationCreate(_driver);
            _locationView = new LocationView(_driver);
            _recentElements = new RecentElements(_driver);

            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _menusTests = new MenusTest();
            _lobby = new LobbyView(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=404871";
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateLocationWithSbsAndMinimalAndSave()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR SBS Standort A";
            _locationCreate.StreetName = "SBS Way 201a-c";
            _locationCreate.Zip = "4554";
            _locationCreate.City = "SBS";

            _locationCreate.SaveButton.Click();

            Assert.AreEqual("SYR SBS Standort A", _locationView.CompanyName);

            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            int retry = 10;
            do
            {
                try
                {
                    StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNo);
                    retry = 0; //no retry necessary anymore
                }
                catch (AssertFailedException)
                {
                    Thread.Sleep(MillisecondsTimeout);
                    _locationMenu.Location.Click();
                    retry--;
                }
            } while (retry > 0);
            Assert.AreEqual("SBS Way 201a-c", _locationView.StreetName);
            Assert.AreEqual("4554", _locationView.Zip);
            Assert.AreEqual("SBS", _locationView.City);
        }

        [Ignore] //obsolete
        [TestMethod]
        public void AgencyOfCustomerIsUsedForAgencyOfLocation()
        {
            string agency = _customerView.Agency;
            _customerMenu.LocationCreate.Click();
            //Assert.AreEqual(agency, _locationCreate.Agency);
        }

        [TestMethod]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = _customerView.Country;
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual(country, _locationCreate.Country);
        }

        [TestMethod]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = _customerView.Language;
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual(language, _locationCreate.Language);
        }


        [TestMethod]
        public void CreateLocationCheckNavBar()
        {
            Assert.AreEqual("Kunde", _navigationBar.Current.Text);
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual("Kunde", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateLocationCheckHeadline()
        {
            _customerMenu.LocationCreate.Click();
            Assert.AreEqual("Neuer Standort", _lobby.Headline.Text);
        }
    }
}