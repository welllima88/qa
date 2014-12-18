using System.Text.RegularExpressions;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Create
{
    [TestFixture]
    public class LocationCreateWithMinimalInputAndSave
    {
        private static string _locId;
        private static string _ep2MerchantId;

        [TestFixtureSetUp]
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

        [Test]
        public void CompanyName()
        {
            Assert.AreEqual("SYR Standort SELE A", View.CompanyName);
        }

        [Test]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
            Assert.AreEqual(_locId, View.Guid);
        }

        [Test]
        public void Ep2MerchantId()
        {
            Assert.AreEqual(_ep2MerchantId, View.Ep2MerchantId);
        }

        [Test]
        public void SbsDebitNumber()
        {
            StringAssert.IsMatch(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
        }

        [Test]
        public void SbsAdressNumber()
        {
            StringAssert.IsMatch(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
        }

        [Test]
        public void Ep2MerchantIdFormat()
        {
            StringAssert.IsMatch(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));
        }

        [Test]
        public void StreetName()
        {
            Assert.AreEqual("Bröselstr. 201a-c", View.StreetNo);
        }

        [Test]
        public void Po()
        {
            Assert.AreEqual("", View.Po);
        }

        [Test]
        public void Zip()
        {
            Assert.AreEqual("55555", View.Zip);
        }

        [Test]
        public void City()
        {
            Assert.AreEqual("München", View.City);
        }

        [Test]
        public void AdressAddition()
        {
            Assert.AreEqual("", View.AdressAddition);
        }

        [Test]
        public void Region()
        {
            Assert.AreEqual("", View.Region);
        }

        [Test]
        public void Language()
        {
            Assert.AreEqual("Französisch [fr]", View.Language);
        }

        [Test]
        public void Country()
        {
            Assert.AreEqual("Frankreich [FR]", View.Country);
        }

        [Test]
        public void Email()
        {
            Assert.AreEqual("", View.Email);
        }

        [Test]
        public void Telephone()
        {
            Assert.AreEqual("", View.Telephone);
        }

        [Test]
        public void Mobile()
        {
            Assert.AreEqual("", View.Mobile);
        }

        [Test]
        public void Fax()
        {
            Assert.AreEqual("", View.Fax);
        }

        [Test]
        public void Web()
        {
            Assert.AreEqual("", View.Web);
        }

        [Test]
        public void CountryOfCustomerIsUsedForAgencyOfLocation()
        {
            string country = Selenium.Customer.View.Country;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(country, Selenium.Location.Create.Country);
        }

        [Test]
        public void LanguageOfCustomerIsUsedForAgencyOfLocation()
        {
            string language = Selenium.Customer.View.Language;
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual(language, Selenium.Location.Create.Language);
        }

        [Test]
        public void CreateLocationCheckNavBar()
        {
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
        }

        [Test]
        public void CreateLocationCheckHeadline()
        {
            CustomerMenu.LocationCreate.Click();
            Assert.AreEqual("Neuer Standort", Lobby.Headline.Text);
        }
    }
}