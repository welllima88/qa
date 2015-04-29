using NUnit.Framework;
using Six.Saferpay.Backoffice.Test.Pages.Common;
using Six.Test.Selenium.WebDriver;

namespace Six.Saferpay.Backoffice.Test.Tests.Lobby
{
    [TestFixture]
    [Category("Navigation")]
    public class MetaNavigationBarTest
    {
        private MetaNavBar _metaNavBar;

        [TestFixtureSetUp]
        public void ClassInit()
        {
            TestDirector.Navigate();
            _metaNavBar = new MetaNavBar();
        }

        [Test]
        [Category("LobbyCheck")]
        public void English()
        {
            Assert.That(_metaNavBar.English.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void French()
        {
            Assert.That(_metaNavBar.French.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Italian()
        {
            Assert.That(_metaNavBar.Italian.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Polish()
        {
            Assert.That(_metaNavBar.Polish.Displayed);
        }
    }
}