using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditWithoutReasonTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
        }

        [TestMethod]
        public void EditLocationAndSave()
        {
            string guid = LocationView.Guid;
            string ep2MerchantId = LocationView.Ep2MerchantId;
            string sbsDebitNumber = LocationView.SbsDebitNumber;
            string sbsAdressNumber = LocationView.SbsAdressNumber;

            LocationMenu.LocationEdit.Click();
            Assert.AreEqual(LocationEdit.Guid, guid);
            Assert.AreEqual(LocationEdit.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual(LocationEdit.SbsDebitNumber, sbsDebitNumber);
            Assert.AreEqual(LocationEdit.SbsAdressNumber, sbsAdressNumber);

            LocationEdit.CompanyName = "SYR Standort SELE B";
            LocationEdit.StreetNo = "Am Bärenplatz 2";
            LocationEdit.Zip = "8001";
            LocationEdit.City = "Kreuzlingen";
            LocationEdit.Po = "PO2-A";
            LocationEdit.AdressAddition = "Level2";
            LocationEdit.SapNumber = "1331";
            LocationEdit.Email = "marc.siegmund@six-group.com";
            LocationEdit.Telephone = "+41 58 399 6237";
            LocationEdit.Mobile = "+42 58 399 6237";
            LocationEdit.Fax = "+43 58 399 6237";
            LocationEdit.Web = "www.six-group.com";

            LocationEdit.Language = "Englisch [en]";
            LocationEdit.Country = "Schweiz [CH]";

            LocationCreate.SaveButton.Click();

            Assert.AreEqual(LocationView.Guid, guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();

            Assert.AreEqual(LocationView.Guid, guid);
            Assert.AreEqual(LocationView.Ep2MerchantId, ep2MerchantId);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);

            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", LocationView.StreetNo);
            Assert.AreEqual("1331", LocationView.SapNumber);
            Assert.AreEqual("SYR Standort SELE B", LocationView.CompanyName);
            Assert.AreEqual("8001", LocationView.Zip);
            Assert.AreEqual("PO2-A", LocationView.Po);
            Assert.AreEqual("Level2", LocationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", LocationView.City);
            Assert.AreEqual("Englisch [en]", LocationView.Language);
            Assert.AreEqual("Schweiz [CH]", LocationView.Country);
            Assert.AreEqual("marc.siegmund@six-group.com", LocationView.Email);
            Assert.AreEqual("+41 58 399 6237", LocationView.Telephone);
            Assert.AreEqual("+42 58 399 6237", LocationView.Mobile);
            Assert.AreEqual("+43 58 399 6237", LocationView.Fax);
            Assert.AreEqual("www.six-group.com", LocationView.Web);
        }
    }
}