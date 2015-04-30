using NUnit.Framework;
using Six.Saferpay.Backoffice.Test.Pages.Common;
using Six.Test.Selenium.WebDriver;

namespace Six.Saferpay.Backoffice.Test.Tests.Lobby
{
    [TestFixture]
    [Category("Navigation")]
    public class NavigationBarTest
    {
        private NavigationBar _navigationBar;

        [TestFixtureSetUp]
        public void ClassInit()
        {
            TestDirector.Navigate();
            _navigationBar = new NavigationBar();
        }

        [Test]
        [Category("LobbyCheck")]
        public void MySaferpay()
        {
            Assert.That(_navigationBar.MySaferpay.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void OnlineSupport()
        {
            Assert.That(_navigationBar.OnlineSupport.Displayed);
        }
    }
}