using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.View.Common;
using Six.Scs.QA.Application.View.Common.Menu;
using Six.Scs.QA.Application.View.Customer;

namespace Six.Scs.QA.Application.SystemTest.Validation.Customer
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