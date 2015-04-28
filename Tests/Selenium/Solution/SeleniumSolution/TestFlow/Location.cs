using Six.Scs.QA.Application.Workflow;
using Six.Scs.QA.Application.Workflow.Builder;

namespace Six.Scs.QA.Testlogic
{
    public class Location
    {
        public static LocationBuilder Edit(Application.Model.ValueObjects.Location location, LocationBuilder locationBuilder)
        {
            Open(location);
            locationBuilder.Edit();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static LocationBuilder Create(Application.Model.ValueObjects.Customer customer, LocationBuilder locationBuilder)
        {
            Customer.Open(customer);
            locationBuilder.Create();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static void Open(Application.Model.ValueObjects.Location location)
        {
            Search.LocationCanBeFoundByLocationName(location.CompanyName);
            // Assert.AreEqual(location.Guid, LocationView.Guid);
        }
    }
}