using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public class LocationService
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
        }

        public static void Check(LocationData l)
        {
            Assert.AreEqual(l.CompanyName, LocationView.CompanyName);
            StringAssert.Matches(LocationView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(LocationView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(LocationView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);
            Assert.AreEqual(l.Adress, LocationView.StreetNo);
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