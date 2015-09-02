using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Mpd;
using Six.Test.Selenium.WebDriver;
using Create = Six.Scs.Test.UI.Administration.Agency.Create;

namespace Six.Scs.Test.Validation.Mpd
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreate()
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