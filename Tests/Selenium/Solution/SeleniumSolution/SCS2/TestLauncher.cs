using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.Worklow;

namespace SIX.SCS.Tests.Selenium
{
    /// <summary>
    ///     The TestLauncher prepares Browser with TestDirector and keeps this
    /// </summary>
    [TestClass]
    public static class TestLauncher
    {
        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            TestEnvironment.Dev();
            TestDirector.PrepareBrowser(SeleniumGridServer.Build);
            TestDirector.Login();
            LobbyService.Language(Languages.German);
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.Logout();
            TestDirector.ShutDownBrowser();
        }
    }
}