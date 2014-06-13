using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Settings;

namespace SIX.SCS.Tests.Selenium
{
    [TestClass]
    public static class TestLauncher
    {
        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            ScsClassicTestEnvironment.Dev();
            TestDirector.PrepareBrowser();
            TestDirector.Login();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.Logout();
            TestDirector.ShutDownBrowser();
        }
    }
}