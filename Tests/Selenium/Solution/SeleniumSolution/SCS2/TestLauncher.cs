using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium
{
    /// <summary>
    ///     The TestLauncher prepares Browser with TestDirector and keeps this
    /// </summary>
    [TestClass]
    public static class TestLauncher
    {
        private static string SetLanguage
        {
            set
            {
                MetaNavBar.Languages.Click();
                MetaNavBar.Language(value).Click();
            }
        }

        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            ScsPlatinTestEnvironment.Dev();
            TestDirector.PrepareBrowser("http://wkbuild03:4488/wd/hub");
            TestDirector.Login();
            SetLanguage = "Deutsch";
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.Logout();
            TestDirector.ShutDownBrowser();
        }
    }
}