using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        public static void Navigate(string urlSuffix = "")
        {
            var suff = new Uri(urlSuffix, UriKind.Relative);
            var url = new Uri(TestEnvironment.BaseUrl, suff);
            TestDirector.WebDriver.Url = url.AbsoluteUri;
        }

        public static long GenerateTestId()
        {
            return DateTime.Now.Ticks;
        }

        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            TestDirector = new TestDirector();
            ScsPlatinTestEnvironment.PrepareForDev();
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