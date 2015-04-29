using Six.Scs.Test.Workflow;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test
{
    public class Location
    {
        public static LocationBuilder Edit(Model.ValueObjects.Location location, LocationBuilder locationBuilder)
        {
            Open(location);
            locationBuilder.Edit();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static LocationBuilder Create(Model.ValueObjects.Customer customer, LocationBuilder locationBuilder)
        {
            Customer.Open(customer);
            locationBuilder.Create();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static void Open(Model.ValueObjects.Location location)
        {
            Search.LocationCanBeFoundByLocationName(location.CompanyName);
            // Assert.AreEqual(location.Guid, LocationView.Guid);
        }
    }
}