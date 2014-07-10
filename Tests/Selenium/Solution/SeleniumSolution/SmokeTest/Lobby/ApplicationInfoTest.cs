using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ApplicationInfoTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Category("LobbyCheck")]
        [Test]
        public void ApplicationName()
        {
            Assert.IsTrue(ApplicationInfo.ApplicationName.Displayed);
        }

        [Category("LobbyCheck")]
        [Test]
        public void Environment()
        {
            Assert.IsTrue(ApplicationInfo.Environment.Displayed);
        }
    }
}