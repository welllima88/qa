using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Location;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Validation.Location
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void CreateLocationWithNoInput()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=1");
            CustomerMenu.LocationCreate.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void City()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("LocationData.Address.City"));
        }

        [Test]
        public void Name()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("LocationData.Name"));
        }

        [Test]
        public void Zip()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("LocationData.Address.ZIP"));
        }
    }
}