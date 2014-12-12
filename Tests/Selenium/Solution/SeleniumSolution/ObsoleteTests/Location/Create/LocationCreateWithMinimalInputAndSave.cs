using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestClass]
    public class LocationCreateWithMinimalInputAndSave
    {
        private static string _locId;
        private static string _ep2MerchantId;

        [ClassInitialize]
        public static void ClassInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=404871");

            CustomerMenu.LocationCreate.Click();

            Selenium.Location.Create.CompanyName = "SYR Standort SELE A";
            Selenium.Location.Create.StreetNo = "Bröselstr. 201a-c";
            Selenium.Location.Create.Zip = "55555";
            Selenium.Location.Create.City = "München";

            Selenium.Location.Create.Language = "Französisch [fr]";
            Selenium.Location.Create.Country = "Frankreich [FR]";

            Selenium.Location.Create.SaveButton.Click();

            _locId = View.Guid;
            _ep2MerchantId = View.Ep2MerchantId;
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Standort SELE A", View.CompanyName);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
            Assert.AreEqual(_locId, View.Guid);
        }

        [TestMethod]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);
        }

        [TestMethod]
        public void SbsDebitNumber()
        {
            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [TestMethod]
        public void SbsAdressNumber()
        {
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [TestMethod]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [TestMethod]
        public void StreetName()
        {
            Assert.AreEqual("Bröselstr. 201a-c", View.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("", View.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", View.Zip);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("München", View.City);
        }

        [TestMethod]
        public void AdressAddition()
        {
            Assert.AreEqual("", View.AdressAddition);
        }

        [TestMethod]
        public void Region()
        {
            Assert.AreEqual("", View.Region);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", View.Language);
        }

        [TestMethod]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", View.Country);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("", View.Email);
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("", View.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("", View.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("", View.Fax);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("", View.Web);
        }

        [TestMethod]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = Selenium.Customer.View.Country;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(country, Selenium.Location.Create.Country);
        }

        [TestMethod]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = Selenium.Customer.View.Language;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(language, Selenium.Location.Create.Language);
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
            Assert.AreEqual("Neuer Standort", Lobby.Headline.Text);
        }
    }
}