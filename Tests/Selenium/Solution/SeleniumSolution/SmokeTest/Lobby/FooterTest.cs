using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class FooterTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void Copyright()
        {
            Assert.That(Footer.Copyright.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Disclaimer()
        {
            Assert.That(Footer.Disclaimer.Displayed);
        }
    }
}