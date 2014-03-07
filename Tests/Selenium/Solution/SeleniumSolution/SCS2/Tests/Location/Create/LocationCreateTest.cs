using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create
{
    [TestClass]
    public class LocationCreateTest
    {
        private static string _locId;
        private static string _ep2MerchantId;
        private static string _companyName;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401983");

            DoCreateLocation();

            _locId = LocationView.Guid;
            _ep2MerchantId = LocationView.Ep2MerchantId;
        }

        [TestMethod]
        public void CompanyName()
        {
            Assert.AreEqual(_companyName, LocationView.CompanyName);
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

        public static void DoCreateLocation()
        {
            CustomerMenu.Customer.Click();
            CustomerMenu.LocationCreate.Click();
            _companyName = "SYR Standort" + TestLauncher.GenerateTestId();
            LocationCreate.CompanyName = _companyName;
            LocationCreate.StreetNo = "Bröselstr. 201a-c";
            LocationCreate.Zip = "55555";
            LocationCreate.City = "München";
            LocationCreate.Po = "PO1";
            LocationCreate.AdressAddition = "AdressAdd1";
            LocationCreate.Region = "Reg 55";
            LocationCreate.SapNumber = "4444";
            LocationCreate.Language = "fr";
            LocationCreate.Country = "FR";
            LocationCreate.Email = "marc.siegmund@six-group.com";
            LocationCreate.Telephone = "0031 58 399 6237";
            LocationCreate.Mobile = "0032 58 399 6237";
            LocationCreate.Fax = "0033 58 399 6237";
            LocationCreate.Web = "www.six-group.com/de-intern";

            LocationCreate.SaveButton.Click();
        }
    }
}