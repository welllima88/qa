using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
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
            _guid = LocationView.Guid;
            _ep2MerchantId = LocationView.Ep2MerchantId;
            _sbsDebitNumber = LocationView.SbsDebitNumber;
            _sbsAdressNumber = LocationView.SbsAdressNumber;

            LocationMenu.LocationEdit.Click();
            Assert.AreEqual(LocationEdit.Guid, _guid);
            Assert.AreEqual(LocationEdit.Ep2MerchantId, _ep2MerchantId);
            Assert.AreEqual(LocationEdit.SbsDebitNumber, _sbsDebitNumber);
            Assert.AreEqual(LocationEdit.SbsAdressNumber, _sbsAdressNumber);

            LocationEdit.CompanyName = "SYR Standort SELE B";
            LocationEdit.StreetNo = "Am Bärenplatz 2";
            LocationEdit.Zip = "8001";
            LocationEdit.City = "Kreuzlingen";
            LocationEdit.Po = "";
            LocationEdit.AdressAddition = "";
            LocationEdit.SapNumber = "";
            LocationEdit.Email = "";
            LocationEdit.Telephone = "";
            LocationEdit.Mobile = "";
            LocationEdit.Fax = "";
            LocationEdit.Web = "";

            LocationEdit.Language = "en";
            LocationEdit.Country = "CH";

            LocationCreate.SaveButton.Click();
        }

        [TestMethod]
        public void EditLocationWithMinimalAndSave()
        {
            Assert.AreEqual(LocationView.Guid, _guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, _ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(LocationView.Guid, _guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, _ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", LocationView.StreetNo);
            Assert.AreEqual("", LocationView.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);
            Assert.AreEqual("8001", LocationView.Zip);
            Assert.AreEqual("", LocationView.Po);
            Assert.AreEqual("", LocationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", LocationView.City);
            StringAssert.Contains(LocationView.Language, "[en]");
            StringAssert.Contains(LocationView.Country, "[CH]");
            Assert.AreEqual("", LocationView.Email);
            Assert.AreEqual("", LocationView.Telephone);
            Assert.AreEqual("", LocationView.Mobile);
            Assert.AreEqual("", LocationView.Fax);
            Assert.AreEqual("", LocationView.Web);
        }
    }
}