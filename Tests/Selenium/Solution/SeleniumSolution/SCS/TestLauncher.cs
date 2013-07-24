using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics
{
    [TestClass]
    public static class TestLauncher
    {
        public static TestDirector TestDirector;

        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            TestDirector = new TestDirector(new Prod());
            TestDirector.PrepareBrowser();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.ShutDownBrowser();
        }
    }
}