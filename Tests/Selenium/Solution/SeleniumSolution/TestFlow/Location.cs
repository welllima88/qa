using NUnit.Framework;
using Six.Scs.Test.Workflow;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test
{
    public static class Location
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

        public static void Activate(LocationBuilder locationBuilder)
        {
            Open(locationBuilder.Location);

            locationBuilder.Activate();
            locationBuilder.Check();
            Assert.That(!View.Location.View.IsCanceled);
            Assert.That(View.Location.View.Quit.Displayed);
        }

        public static void Quit(LocationBuilder locationBuilder)
        {
            Open(locationBuilder.Location);
            locationBuilder.Quit();
            locationBuilder.Check();
            Assert.That(View.Location.View.IsCanceled);
            Assert.That(View.Location.View.Activate.Displayed);
        }
    }
}