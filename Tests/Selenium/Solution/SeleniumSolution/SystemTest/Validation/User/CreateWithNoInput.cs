using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.User;
using List = Six.Scs.QA.Selenium.View.User.List;

namespace Six.Scs.QA.Selenium.SystemTest.Validation.User
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreateContact()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=1");
            CustomerMenu.Users.Click();
            List.UserCreate.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void FirstName()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("UserData.Firstname"));
        }

        [Test]
        public void Name()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("UserData.Name"));
        }

        [Test]
        public void UserName()
        {
            Assert.That(Create.UserName, Is.Not.Empty);
        }
    }
}