using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSClassics.Tests.Selenium.Settings;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium
{
    [TestClass]
    public static class TestLauncher
    {
        public static TestDirector TestDirector;

        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            TestDirector = new TestDirector();
            ScsClassiicTestEnvironment.Dev();
            TestDirector.PrepareBrowser();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.ShutDownBrowser();
        }
    }
}