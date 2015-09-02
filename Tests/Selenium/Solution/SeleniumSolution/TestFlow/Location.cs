using NUnit.Framework;
using Six.Scs.Test.Builder.Location;
using Six.Scs.Test.UI.Location;
using Six.Scs.Test.Workflow;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test
{
    public static class Location
    {
        public static LocationBuilder Edit(Model.Location location, LocationBuilder locationBuilder)
        {
            Open(location);
            locationBuilder.Edit();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static LocationBuilder Create(Model.Customer customer, LocationBuilder locationBuilder)
        {
            Customer.Open(customer);
            locationBuilder.Create();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }

        public static void Open(Model.Location location)
        {
            Search.LocationCanBeFoundByLocationName(location.CompanyName);
            // Assert.AreEqual(location.Guid, LocationView.Guid);
        }

        public static void Activate(LocationBuilder locationBuilder)
        {
            Open(locationBuilder.Location);

            locationBuilder.Activate();
            locationBuilder.Check();
            Assert.That(!View.IsCanceled);
            Assert.That(View.Quit.Displayed);
        }

        public static void Quit(LocationBuilder locationBuilder)
        {
            Open(locationBuilder.Location);
            locationBuilder.Quit();
            locationBuilder.Check();
            Assert.That(View.IsCanceled);
            Assert.That(View.Activate.Displayed);
        }

        public static LocationBuilder CreateFromCustomer(Model.Customer customer)
        {
            Customer.Open(customer);
            var locationBuilder = new FromCustomer(customer);
            locationBuilder.Create();
            locationBuilder.Check();
            Lobby.OpenLatestElement();
            locationBuilder.Check();
            return locationBuilder;
        }
    }
}