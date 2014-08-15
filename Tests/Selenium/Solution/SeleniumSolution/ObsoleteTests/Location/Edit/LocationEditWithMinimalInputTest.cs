using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Location;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Location.Edit
{
    [TestClass]
    public class LocationEditWithMinimalInputTest
    {
        private string _ep2MerchantId;
        private string _guid;
        private string _sbsAdressNumber;
        private string _sbsDebitNumber;

        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
            _guid = View.Guid;
            _ep2MerchantId = View.Ep2MerchantId;
            _sbsDebitNumber = View.SbsDebitNumber;
            _sbsAdressNumber = View.SbsAdressNumber;

            LocationMenu.LocationEdit.Click();
            Assert.AreEqual(Selenium.Location.Edit.Guid, _guid);
            Assert.AreEqual(Selenium.Location.Edit.Ep2MerchantId, _ep2MerchantId);
            Assert.AreEqual(Selenium.Location.Edit.SbsDebitNumber, _sbsDebitNumber);
            Assert.AreEqual(Selenium.Location.Edit.SbsAdressNumber, _sbsAdressNumber);

            Selenium.Location.Edit.CompanyName = "SYR Standort SELE B";
            Selenium.Location.Edit.StreetNo = "Am Bärenplatz 2";
            Selenium.Location.Edit.Zip = "8001";
            Selenium.Location.Edit.City = "Kreuzlingen";
            Selenium.Location.Edit.Po = "";
            Selenium.Location.Edit.AdressAddition = "";
            Selenium.Location.Edit.SapNumber = "";
            Selenium.Location.Edit.Email = "";
            Selenium.Location.Edit.Telephone = "";
            Selenium.Location.Edit.Mobile = "";
            Selenium.Location.Edit.Fax = "";
            Selenium.Location.Edit.Web = "";

            Selenium.Location.Edit.Language = "en";
            Selenium.Location.Edit.Country = "CH";

            Selenium.Location.Create.SaveButton.Click();
        }

        [TestMethod]
        public void EditLocationWithMinimalAndSave()
        {
            Assert.AreEqual(View.Guid, _guid);
            Assert.AreEqual(View.Ep2MerchantId, _ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", View.CompanyName);

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual(View.Guid, _guid);
            Assert.AreEqual(View.Ep2MerchantId, _ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", View.CompanyName);

            StringAssert.Matches(View.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            StringAssert.Matches(View.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
            StringAssert.Matches(View.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            Assert.AreEqual("Am Bärenplatz 2", View.StreetNo);
            Assert.AreEqual("", View.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", View.CompanyName);
            Assert.AreEqual("8001", View.Zip);
            Assert.AreEqual("", View.Po);
            Assert.AreEqual("", View.AdressAddition);
            Assert.AreEqual("Kreuzlingen", View.City);
            StringAssert.Contains(View.Language, "[en]");
            StringAssert.Contains(View.Country, "[CH]");
            Assert.AreEqual("", View.Email);
            Assert.AreEqual("", View.Telephone);
            Assert.AreEqual("", View.Mobile);
            Assert.AreEqual("", View.Fax);
            Assert.AreEqual("", View.Web);
        }
    }
}