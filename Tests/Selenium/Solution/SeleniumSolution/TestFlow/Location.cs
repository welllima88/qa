using Six.Scs.QA.Selenium.Workflow;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic
{
    public class Location
    {
        public static LocationBuilder Edit(Selenium.Model.ValueObjects.Location location, LocationBuilder locationBuilder)
        {
            Open(location);
            locationBuilder.Edit();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static LocationBuilder Create(Selenium.Model.ValueObjects.Customer customer, LocationBuilder locationBuilder)
        {
            Customer.Open(customer);
            locationBuilder.Create();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static void Open(Selenium.Model.ValueObjects.Location location)
        {
            Search.LocationCanBeFoundByLocationName(location.CompanyName);
            // Assert.AreEqual(location.Guid, LocationView.Guid);
        }
    }
}