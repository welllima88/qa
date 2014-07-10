using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    [TestFixture]
    public class LobbyHeaderTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void Headline()
        {
            StringAssert.Contains("Lobby", SiteContent.Header);
        }
    }
}