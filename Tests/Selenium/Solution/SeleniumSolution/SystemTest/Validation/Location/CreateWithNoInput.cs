using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Location;

namespace Six.Scs.QA.Selenium.SystemTest.Validation.Location
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