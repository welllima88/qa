using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Views.Common;

namespace Six.Saferpay.QA.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class NavigationBarTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void MySaferpay()
        {
            Assert.That(NavigationBar.MySaferpay.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void OnlineSupport()
        {
            Assert.That(NavigationBar.OnlineSupport.Displayed);
        }
    }
}