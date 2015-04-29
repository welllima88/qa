using NUnit.Framework;
using Six.Scs.Test.View.Common;
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
            Assert.IsTrue(Footer.Copyright.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Disclaimer()
        {
            Assert.IsTrue(Footer.Disclaimer.Displayed);
        }
    }
}