using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium
{
    /// <summary>
    ///     The TestLauncher prepares Browser with TestDirector and keeps this
    /// </summary>
    [SetUpFixture]
    public static class TestLauncher
    {
        [SetUp]
        public static void LaunchTestDirector(TestContext testContext)
        {
            ScsEnvironment.Dev();
            TestDirector.PrepareBrowser(SeleniumGridServer.Local);
            TestDirector.LogOn();
            LobbyService.ChooseLanguage(Languages.German);
        }

        [TearDown]
        public static void StopTestDirector()
        {
            TestDirector.LogOff();
            TestDirector.ShutdownBrowser();
        }
    }
}