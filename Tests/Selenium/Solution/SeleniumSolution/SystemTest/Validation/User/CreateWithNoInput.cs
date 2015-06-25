using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.User;
using Six.Test.Selenium.WebDriver;
using List = Six.Scs.Test.View.User.List;

namespace Six.Scs.Test.Validation.User
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreate()
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