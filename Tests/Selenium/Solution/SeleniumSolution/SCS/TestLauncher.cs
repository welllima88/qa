using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Settings;

namespace Six.Scs.Tests.Selenium
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