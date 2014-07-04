using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestData.Factory;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.Location;

namespace Six.Scs.QA.Selenium.Extension.Worklow
{
    public static class LocationService
    {
        public static void Create(LocationData l)
        {
            CustomerMenu.Customer.Click();

            CustomerMenu.LocationCreate.Click();

            LocationCreate.CompanyName = l.CompanyName;
            LocationCreate.StreetNo = l.Adress.StreetNo;
            LocationCreate.Zip = l.Adress.Zip;
            LocationCreate.City = l.Adress.City;
            LocationCreate.Po = l.Adress.Po;
            LocationCreate.AdressAddition = l.Adress.AdressAddition;
            LocationCreate.Region = l.Adress.Region;
            LocationCreate.SapNumber = l.SapNumber;
            LocationCreate.Language = l.Contact.Language;
            LocationCreate.Country = l.Adress.Country;
            LocationCreate.Email = l.Contact.Email;
            LocationCreate.Telephone = l.Contact.Telephone;
            LocationCreate.Mobile = l.Contact.Mobile;
            LocationCreate.Fax = l.Contact.Fax;
            LocationCreate.Web = l.Contact.Web;

            LocationCreate.SaveButton.Click();

            l.Guid = LocationView.Guid;
            l.Ep2MerchantId = LocationView.Ep2MerchantId;
            l.SbsDebitNumber = LocationView.SbsDebitNumber;
            l.SbsAdressNumber = LocationView.SbsAdressNumber;
        }

        /// <summary>
        ///     Edits location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Edit(LocationData l)
        {
            l.Guid = LocationView.Guid;
            l.Ep2MerchantId = LocationView.Ep2MerchantId;
            l.SbsDebitNumber = LocationView.SbsDebitNumber;
            l.SbsAdressNumber = LocationView.SbsAdressNumber;

            LocationView.EditButton.Click();

            LocationEdit.CompanyName = l.CompanyName;
            LocationEdit.StreetNo = l.Adress.StreetNo;
            LocationEdit.Zip = l.Adress.Zip;
            LocationEdit.City = l.Adress.City;
            LocationEdit.Po = l.Adress.Po;
            LocationEdit.Region = l.Adress.Region;
            LocationEdit.AdressAddition = l.Adress.AdressAddition;
            LocationEdit.SapNumber = l.SapNumber;
            LocationEdit.Email = l.Contact.Email;
            LocationEdit.Telephone = l.Contact.Telephone;
            LocationEdit.Mobile = l.Contact.Mobile;
            LocationEdit.Fax = l.Contact.Fax;
            LocationEdit.Web = l.Contact.Web;

            LocationEdit.Language = l.Contact.Language;
            LocationEdit.Country = l.Adress.Country;

            LocationEdit.Reason = "CorrectionOnly";
            ChangeForm.Reason = "MerchantAddressChange";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " location change remark";

            LocationCreate.SaveButton.Click();
        }

        /// <summary>
        ///     Verifies the location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Check(LocationData l)
        {
            Assert.AreEqual(l.CompanyName, LocationView.CompanyName);
            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, LocationView.SbsDebitNumber);
            StringAssert.IsMatch(TestRegExpPatterns.SbsAdressNoOpt, LocationView.SbsAdressNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, LocationView.Ep2MerchantId);
            Assert.AreEqual(l.Adress.StreetNo, LocationView.StreetNo);
            Assert.AreEqual(l.Adress.Po, LocationView.Po);
            Assert.AreEqual(l.Adress.Zip, LocationView.Zip);
            Assert.AreEqual(l.Adress.City, LocationView.City);
            Assert.AreEqual(l.Adress.Region, LocationView.Region);
            Assert.AreEqual(l.Adress.AdressAddition, LocationView.AdressAddition);
            Assert.AreEqual(l.Contact.Language, LocationView.Language);
            Assert.AreEqual(l.Adress.Country, LocationView.Country);
            Assert.AreEqual(l.Contact.Email, LocationView.Email);
            Assert.AreEqual(l.Contact.Telephone, LocationView.Telephone);
            Assert.AreEqual(l.Contact.Mobile, LocationView.Mobile);
            Assert.AreEqual(l.Contact.Fax, LocationView.Fax);
            Assert.AreEqual(l.Contact.Web, LocationView.Web);
        }
    }
}