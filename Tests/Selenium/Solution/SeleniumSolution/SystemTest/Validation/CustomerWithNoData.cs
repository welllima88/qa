using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;

namespace Six.Scs.QA.Selenium.SystemTest.Validation
{
    [TestFixture]
    public class CreateCustomerWithNoInput
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
        public void CustomerName()
        {
            
            Assert.That(FormAlert.FormAlertList, Contains.Item("Dies ist ein Pflichtfeld!"));
        }
    }
}