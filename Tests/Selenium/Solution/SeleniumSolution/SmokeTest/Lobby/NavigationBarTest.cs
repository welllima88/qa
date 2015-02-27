using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
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
        public void Administration()
        {
            Assert.IsTrue(NavigationBar.Administration.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Help()
        {
            Assert.IsTrue(NavigationBar.Help.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Lobby()
        {
            Assert.IsTrue(NavigationBar.Lobby.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Reporting()
        {
            Assert.IsTrue(NavigationBar.Reporting.Displayed);
        }
    }
}