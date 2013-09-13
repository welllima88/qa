using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Customer;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMinimalInputAndSbsExportAndSave
    {
        private const int MillisecondsTimeout = 1000;
        private static LocationView _locationView;
        private static NavigationBar _navigationBar;
        private static LocationCreate _locationCreate;
        private static LocationMenu _locationMenu;
        private static CustomerMenu _customerMenu;
        private static CustomerView _customerView;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _customerView = new CustomerView();
            _locationMenu = new LocationMenu();
            _locationCreate = new LocationCreate();
            _locationView = new LocationView();
            _navigationBar = new NavigationBar();
            _lobby = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");
        }

        [TestMethod]
        public void CreateLocationWithSbsAndMinimalAndSave()
        {
            _customerMenu.LocationCreate.Click();

            _locationCreate.CompanyName = "SYR SBS Standort A";
            _locationCreate.StreetNo = "SBS Way 201a-c";
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
            Assert.AreEqual("SBS Way 201a-c", _locationView.StreetNo);
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