using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Lobby
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
            Assert.That(NavigationBar.Administration.Displayed);
            Assert.That(NavigationBar.Administration.Text, Is.EqualTo("Verwaltung"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void Help()
        {
            Assert.That(NavigationBar.Help.Displayed);
            Assert.That(NavigationBar.Help.Text, Is.EqualTo("Hilfe"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void Lobby()
        {
            Assert.That(NavigationBar.Lobby.Displayed);
            Assert.That(NavigationBar.Lobby.Text, Contains.Substring("Lobby"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void Reporting()
        {
            Assert.That(NavigationBar.Reporting.Displayed);
            Assert.That(NavigationBar.Reporting.Text, Is.EqualTo("Reporting"));
        }
    }
}