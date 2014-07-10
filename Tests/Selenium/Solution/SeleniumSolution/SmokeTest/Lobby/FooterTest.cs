using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
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

        [Test]
        [Category("LobbyCheck")]
        public void Feedback()
        {
            Assert.IsTrue(Footer.Feedback.Displayed);
        }
    }
}