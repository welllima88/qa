using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateAndSave
    {
        private static string _locId;
        private static string _ep2MerchantId;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=404871");

            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = "SYR Standort SELE A";
            LocationCreate.StreetNo = "Bröselstr. 201a-c";
            LocationCreate.Zip = "55555";
            LocationCreate.City = "München";
            LocationCreate.Po = "PO1";
            LocationCreate.AdressAddition = "AdressAdd1";
            LocationCreate.Region = "Reg 55";
            LocationCreate.SapNumber = "4444";

            LocationCreate.Language = "Französisch [fr]";
            LocationCreate.Country = "Frankreich [FR]";
            LocationCreate.Email = "marc.siegmund@six-group.com";
            LocationCreate.Telephone = "0031 58 399 6237";
            LocationCreate.Mobile = "0032 58 399 6237";
            LocationCreate.Fax = "0033 58 399 6237";
            LocationCreate.Web = "www.six-group.com/de-intern";

            LocationCreate.SaveButton.Click();

            _locId = LocationView.Guid;
            _ep2MerchantId = LocationView.Ep2MerchantId;
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
            RecentElements.MostRecent.Click();

            Assert.AreEqual(_locId, LocationView.Guid);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, LocationView.Ep2MerchantId);
        }

        [TestMethod]
        public void SbsDebitorNo()
        {
            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
        }

        [TestMethod]
        public void SbsAdressNoOpt()
        {
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
        }

        [TestMethod]
        public void StreetName()
        {
            Assert.AreEqual("Bröselstr. 201a-c", LocationView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("PO1", LocationView.Po);
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
        public void Region()
        {
            Assert.AreEqual("Reg 55", LocationView.Region);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual("AdressAdd1", LocationView.AdressAddition);
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
            Assert.AreEqual("marc.siegmund@six-group.com", LocationView.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("0031 58 399 6237", LocationView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("0032 58 399 6237", LocationView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("0033 58 399 6237", LocationView.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("www.six-group.com/de-intern", LocationView.Web);
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