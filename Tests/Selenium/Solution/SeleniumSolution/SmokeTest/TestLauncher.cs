using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium.SmokeTest
{
    /// <summary>
    ///     The TestLauncher prepares Browser with TestDirector and keeps this
    /// </summary>
    [SetUpFixture]
    public class TestLauncher
    {
        [SetUp]
        public void LaunchTestDirector()
        {
            ScsEnvironment.Dev();
            TestDirector.PrepareBrowser(SeleniumGridServer.Local);
            TestDirector.LogOn();
            LobbyService.ChooseLanguage(Languages.German);
        }

        [TearDown]
        public void StopTestDirector()
        {
            TestDirector.LogOff();
            TestDirector.ShutdownBrowser();
        }
    }
}