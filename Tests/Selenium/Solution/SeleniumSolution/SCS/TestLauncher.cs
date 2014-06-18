using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Settings;

namespace Six.Scs.QA.Selenium
{
    [TestClass]
    public static class TestLauncher
    {
        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            ScsClassicTestEnvironment.Dev();
            TestDirector.PrepareBrowser();
            TestDirector.LogOn();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.LogOff();
            TestDirector.ShutdownBrowser();
        }
    }
}