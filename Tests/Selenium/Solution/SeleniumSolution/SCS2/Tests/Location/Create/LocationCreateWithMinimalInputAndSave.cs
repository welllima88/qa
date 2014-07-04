using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.Customer;
using Six.Scs.QA.Selenium.Extension.TestObjects.Location;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Tests.Menu;

namespace Six.Scs.QA.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMinimalInputAndSave
    {
        private static string _locId;
        private static string _ep2MerchantId;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=404871");

            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = "SYR Standort SELE A";
            LocationCreate.StreetNo = "Bröselstr. 201a-c";
            LocationCreate.Zip = "55555";
            LocationCreate.City = "München";

            LocationCreate.Language = "Französisch [fr]";
            LocationCreate.Country = "Frankreich [FR]";

            LocationCreate.SaveButton.Click();

            _locId = LocationView.Guid;
            _ep2MerchantId = LocationView.Ep2MerchantId;
        }

        [TestMethod]
        public void MenuTest()
        {
            MenusTest.LocationMenuCheck();
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Standort SELE A", LocationView.CompanyName);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
            Assert.AreEqual(_locId, LocationView.Guid);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, LocationView.Ep2MerchantId);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(LocationView.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(LocationView.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(LocationView.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [TestMethod]
        public void StreetName()
        {
            Assert.AreEqual("Bröselstr. 201a-c", LocationView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", LocationView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", LocationView.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("München", LocationView.City);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual("", LocationView.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", LocationView.Region);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", LocationView.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", LocationView.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", LocationView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("", LocationView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", LocationView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", LocationView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("", LocationView.Web);
        }

        [TestMethod]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = CustomerView.Country;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(country, LocationCreate.Country);
        }

        [TestMethod]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = CustomerView.Language;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(language, LocationCreate.Language);
        }

        [TestMethod]
        public void CreateLocationCheckNavBar()
        {
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateLocationCheckHeadline()
        {
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Neuer Standort", LobbyView.Headline.Text);
        }
    }
}