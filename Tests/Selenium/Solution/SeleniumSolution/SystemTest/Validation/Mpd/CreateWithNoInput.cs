using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Mpd;
using Six.Test.Selenium.WebDriver;
using Create = Six.Scs.Test.View.Administration.Agency.Create;

namespace Six.Scs.Test.Validation.Mpd
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreateContact()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=1");
            CustomerMenu.AllMpds.Click();
            ListView.CreateButton.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void Address()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("InetAddr"));
        }

        [Test]
        public void Description()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("Description"));
        }

        [Test]
        public void Port()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("InetPort"));
        }
    }
}