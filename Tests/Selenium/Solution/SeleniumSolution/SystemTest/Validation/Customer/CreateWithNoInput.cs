using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Customer;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Validation.Customer
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreateCustomer()
        {
            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
            Create.Supplier = "SIX Payment Services AG";
            Create.Confirm.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void City()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("CustomerData.Address.City"));
        }

        [Test]
        public void Name()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("CustomerData.Name"));
        }

        [Test]
        public void Zip()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("CustomerData.Address.ZIP"));
        }
    }
}