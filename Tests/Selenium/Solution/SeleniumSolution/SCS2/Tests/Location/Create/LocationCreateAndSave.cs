﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateAndSave
    {
        private static LocationView _locationView;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static LocationCreate _locationCreate;
        private static CustomerMenu _customerMenu;
        private static CustomerView _customerView;
        private static LobbyView _lobby;

        private static string _locId;
        private static string _ep2MerchantId;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _customerMenu = new CustomerMenu(_driver);
            _customerView = new CustomerView(_driver);
            _locationCreate = new LocationCreate(_driver);
            _locationView = new LocationView(_driver);
            _recentElements = new RecentElements(_driver);

            _navigationBar = new NavigationBar(_driver);
            _lobby = new LobbyView(_driver);

            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=404871";

            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR Standort SELE A";
            _locationCreate.StreetName = "Bröselstr. 201a-c";
            _locationCreate.Zip = "55555";
            _locationCreate.City = "München";
            _locationCreate.Po = "PO1";
            _locationCreate.AdressAddition = "AdressAdd1";
            _locationCreate.Region = "Reg 55";
            _locationCreate.SapNumber = "4444";

            _locationCreate.Language = "Französisch [fr]";
            _locationCreate.Country = "Frankreich [FR]";
            _locationCreate.Email = "marc.siegmund@six-group.com";
            _locationCreate.Telephone = "0031 58 399 6237";
            _locationCreate.Mobile = "0032 58 399 6237";
            _locationCreate.Fax = "0033 58 399 6237";
            _locationCreate.Web = "www.six-group.com/de-intern";

            _locationCreate.SaveButton.Click();

            _locId = _locationView.Guid;
            _ep2MerchantId = _locationView.Ep2MerchantId;
        }

        [TestInitialize]
        public void TestInit()
        {
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
        public void CompanyName()
        {
            Assert.AreEqual("SYR Standort SELE A", _locationView.CompanyName);
        }

        [TestMethod]
        public void RecentElements()
        {
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual(_locId, _locationView.Guid);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, _locationView.Ep2MerchantId);
        }

        [TestMethod]
        public void SbsDebitorNo()
        {
            StringAssert.Matches(_locationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNoOpt()
        {
            StringAssert.Matches(_locationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(_locationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void StreetName()
        {
            Assert.AreEqual("Bröselstr. 201a-c", _locationView.StreetName);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("PO1", _locationView.Po);
        }


        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", _locationView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("München", _locationView.City);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("Reg 55", _locationView.Region);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual("AdressAdd1", _locationView.AdressAddition);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", _locationView.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", _locationView.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("marc.siegmund@six-group.com", _locationView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("0031 58 399 6237", _locationView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("0032 58 399 6237", _locationView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("0033 58 399 6237", _locationView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("www.six-group.com/de-intern", _locationView.Web);
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