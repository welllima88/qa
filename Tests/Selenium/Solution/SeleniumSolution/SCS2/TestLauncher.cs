using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Settings;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    /// <summary>
    ///     The TestLauncher prepares Browser with a concrete TestDirector and keeps this
    /// </summary>
    [TestClass]
    public static class TestLauncher
    {
        public static TestDirector TestDirector;

        public static void Navigate(string urlSuffix)
        {
            TestDirector.WebDriver.Url = TestEnvironment.BaseUrl + urlSuffix;
        }

        public static long GenerateTestId()
        {
            return DateTime.Now.Ticks;
        }

        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            TestDirector = new TestDirector(new Dev());
            TestDirector.PrepareBrowser();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.ShutDownBrowser();
        }
    }
}