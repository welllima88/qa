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
    public class LocationCreateWithMissingTest
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

        private static long _dt;
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

            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=404871";
        }

        [TestInitialize]
        public void TestInit()
        {
            _dt = DateTime.Now.Ticks; //timestamp for each test
            
            _locationCreate.CompanyName = "SYR Sele Firma A";
            _locationCreate.StreetName = "Hardturmstr. 201";
            _locationCreate.Zip = "8021";
            _locationCreate.City = "Zürich";
            _locationCreate.Po = "PFO1";
            _locationCreate.AdressAddition = "Etage 3";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4440";

            _locationCreate.Language = "Deutsch [de]";
            _locationCreate.Country = "Schweiz [CH]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";
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
        public void CreateLocationrWithoutCompanyNameFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "";


            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutStreetAndNumberFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.StreetName = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutCityFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.City = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateLocationWithoutZipFailed()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.Zip = "";

            _locationCreate.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 1);
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
        }
   }
}