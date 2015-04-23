using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Person;

namespace Six.Scs.QA.Selenium.SystemTest.Validation.Person
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