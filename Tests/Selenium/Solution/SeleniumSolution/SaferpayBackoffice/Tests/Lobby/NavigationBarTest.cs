using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Views.Common;

namespace Six.Saferpay.QA.Selenium.Tests.Lobby
{
    [TestFixture]
    [Category("Navigation")]
    public class NavigationBarTest
    {
        private NavigationBar navigationBar;

        [TestFixtureSetUp]
        public void ClassInit()
        {
            TestDirector.Navigate();
            navigationBar = new NavigationBar();
            PageFactory.InitElements(TestDirector.WebDriver, navigationBar);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MySaferpay()
        {
            Assert.That(navigationBar.MySaferpay.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void OnlineSupport()
        {
            Assert.That(navigationBar.OnlineSupport.Displayed);
        }
    }
}