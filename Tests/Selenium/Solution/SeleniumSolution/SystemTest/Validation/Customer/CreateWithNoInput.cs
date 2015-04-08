using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;

namespace Six.Scs.QA.Selenium.SystemTest.Validation.Customer
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [SetUp]
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