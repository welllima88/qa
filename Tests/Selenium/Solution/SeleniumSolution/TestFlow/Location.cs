using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Location
    {
        public static TestData.ValueObjects.Location Edit(TestData.ValueObjects.Location location)
        {
            Open(location);
            TestData.ValueObjects.Location _location = LocationFactory.Edit();
            Workflow.Location.Edit(_location);
            Check(_location);

            Lobby.OpenLatestElement();
            Check(_location);
            return _location;
        }

        public static TestData.ValueObjects.Location Create(TestData.ValueObjects.Customer customer)
        {
            TestData.ValueObjects.Location location = LocationFactory.Create();
            Workflow.Location.Create(location);
            Check(location);

            Lobby.OpenLatestElement();
            Check(location);
            return location;
        }

        public static void Open(TestData.ValueObjects.Location location)
        {
            Search.LocationCanBeFoundByLocationName(location.CompanyName);
            // Assert.AreEqual(location.Guid, LocationView.Guid);
        }
        /// <summary>
        ///     Verifies the location
        /// </summary>
        /// <param name="l">given location data</param>
        public static void Check(TestData.ValueObjects.Location l)
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