using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Customer;
using Six.Test.Selenium.WebDriver;
using Create = Six.Scs.Test.UI.Person.Create;

namespace Six.Scs.Test.Validation.Person
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreate()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=1");
            View.ContactCreate.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void Name()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("PersonData.LastName"));
        }
    }
}