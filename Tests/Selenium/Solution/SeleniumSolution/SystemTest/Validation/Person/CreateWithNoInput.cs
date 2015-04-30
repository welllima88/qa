using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Person;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Validation.Person
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreateContact()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=1");
            CustomerMenu.ContactCreate.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void Name()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("PersonData.LastName"));
        }
    }
}