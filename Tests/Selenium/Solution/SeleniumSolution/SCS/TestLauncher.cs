using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSClassics.Tests.Selenium.Settings;
using SIX.SCS.QA.Selenium.Extension.Selenium;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium
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