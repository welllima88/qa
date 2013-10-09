using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Settings;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium
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
            TestDirector.WebDriver.Url = new Uri(TestEnvironment.BaseUrl, urlSuffix).AbsoluteUri;
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

        public static void Navigate()
        {
            Navigate("");
        }
    }
}