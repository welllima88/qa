using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.View.Common;

namespace Six.Scs.QA.Application.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class RecentElementsTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void MostRecentContainer()
        {
            Assert.IsTrue(RecentElements.Latest.Displayed);
        }
    }
}