using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Customer;

namespace Six.Scs.QA.Selenium.SystemTest.Defaults
{
    [TestFixture]
    public class MandantIsSavedForNextCustomerCreate
    {
        [SetUp]
        public void GoToCreateCustomer()
        {
        }

        [Test]
        public void CustomerName([Values("SIX Payment Services AG", "CETREL S.A.", "easycash NSP")] string supplier)
        {
            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
            Create.Supplier = supplier;
            Create.Confirm.Click();

            TestDirector.Navigate();
            CustomerMenu.CustomerCreate.Click();
            Assert.That(Create.Supplier, Is.EqualTo(supplier));
        }
    }
}