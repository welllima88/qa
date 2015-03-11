using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Views.Common;

namespace Six.Saferpay.QA.Selenium.Tests.Lobby
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