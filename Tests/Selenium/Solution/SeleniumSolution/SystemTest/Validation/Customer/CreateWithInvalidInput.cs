using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Customer;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Validation.Customer
{
    //[TestFixture]
    public class CreateWithInvalidInput
    {
        //[TestFixtureSetUp]
        public void CreateAndInvalidInput()
        {
            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
            //Testlogic.Customer.Create(new Invalid());
            Create.Confirm.Click();
            Create.SaveButton.Click();
        }

        //[Test]
        public void City()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("CustomerData.Address.City"));
        }
    }
}