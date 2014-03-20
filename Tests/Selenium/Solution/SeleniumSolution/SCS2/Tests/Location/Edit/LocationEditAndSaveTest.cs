using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Edit
{
    [TestClass]
    public class LocationEditAndSaveTest
    {
        private static string _ep2MerchantId;
        private static string _guid;
        private static string _sbsAdressNumber;
        private static string _sbsDebitNumber;
        private static string _locationName;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            TestDirector.Navigate("Location/?LOCATIONID=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
        }

        [TestMethod]
        public void EditLocationAndSave()
        {
            Edit();

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Check();
        }

        public static void Edit()
        {
            _guid = LocationView.Guid;
            _ep2MerchantId = LocationView.Ep2MerchantId;
            _sbsDebitNumber = LocationView.SbsDebitNumber;
            _sbsAdressNumber = LocationView.SbsAdressNumber;

            LocationView.EditButton.Click();

            _locationName = LocationEdit.CompanyName = "SYR Standort" + TestLauncher.GenerateTestId();
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

            LocationEdit.Language = "en";
            LocationEdit.Country = "CH";
            LocationEdit.Reason = "CorrectionOnly";

            ChangeForm.Reason = "MerchantAddressChange";
            ChangeForm.Remark = "SYR " + TestLauncher.GenerateTestId() + " location change remark";

            LocationCreate.SaveButton.Click();
        }

        public static void Check()
        {
            Assert.AreEqual(_locationName, LocationView.CompanyName);
            Assert.AreEqual(LocationEdit.Guid, _guid);//
            Assert.AreEqual(LocationEdit.Ep2MerchantId, _ep2MerchantId);//
            Assert.AreEqual(LocationEdit.SbsDebitNumber, _sbsDebitNumber);//
            Assert.AreEqual(LocationEdit.SbsAdressNumber, _sbsAdressNumber);//

            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            Assert.AreEqual("Am Bärenplatz 2", LocationView.StreetNo);
            Assert.AreEqual("1331", LocationView.SapNumber);
            Assert.AreEqual("8001", LocationView.Zip);
            Assert.AreEqual("PO2-A", LocationView.Po);
            Assert.AreEqual("Level2", LocationView.AdressAddition);
            Assert.AreEqual("Kreuzlingen", LocationView.City);
            StringAssert.Contains(LocationView.Language, "[en]");
            StringAssert.Contains(LocationView.Country, "[CH]");
            Assert.AreEqual("marc.siegmund@six-group.com", LocationView.Email);
            Assert.AreEqual("+41 58 399 6237", LocationView.Telephone);
            Assert.AreEqual("+42 58 399 6237", LocationView.Mobile);
            Assert.AreEqual("+43 58 399 6237", LocationView.Fax);
            Assert.AreEqual("www.six-group.com", LocationView.Web);
        }
    }
}