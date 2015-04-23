using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Mpd;
using Create = Six.Scs.QA.Selenium.View.Administration.Agency.Create;

namespace Six.Scs.QA.Selenium.SystemTest.Validation.Mpd
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