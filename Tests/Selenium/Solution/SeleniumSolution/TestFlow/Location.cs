using NUnit.Framework;
using Six.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Location
    {
        public static TestData.ValueObjects.Location Edit(TestData.ValueObjects.Location location)
        {
            Open(location);
            TestData.ValueObjects.Location _location = TestData.Factory.Location.Edit();
            Workflow.Location.Edit(_location);
            Check(_location);

            Lobby.OpenLatestElement();
            Check(_location);
            return _location;
        }

        public static TestData.ValueObjects.Location Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            TestData.ValueObjects.Location location = TestData.Factory.Location.Create();
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
            Assert.AreEqual(l.CompanyName, View.CompanyName);
            StringAssert.IsMatch(TestRegExpPatterns.SbsDebitorNo, View.SbsDebitNumber);
            // StringAssert.IsMatch(TestRegExpPatterns.SbsAdressNoOpt, LocationView.SbsAdressNumber);
            StringAssert.IsMatch(TestRegExpPatterns.Ep2MerchantId, View.Ep2MerchantId);
            Assert.AreEqual(l.Adress.StreetNo, View.StreetNo);
            Assert.AreEqual(l.Adress.Po, View.Po);
            Assert.AreEqual(l.Adress.Zip, View.Zip);
            Assert.AreEqual(l.Adress.City, View.City);
            StringAssert.Contains(l.Adress.Region, View.Region);
            Assert.AreEqual(l.Adress.AdressAddition, View.AdressAddition);
            Assert.AreEqual(l.Contact.Language, View.Language);
            Assert.AreEqual(l.Adress.Country, View.Country);
            Assert.AreEqual(l.Contact.Email, View.Email);
            StringAssert.Contains(l.Contact.Telephone, View.Telephone);
            StringAssert.Contains(l.Contact.Mobile, View.Mobile);
            StringAssert.Contains(l.Contact.Fax, View.Fax);
            Assert.AreEqual(l.Contact.Web, View.Web);
        }
    }
}