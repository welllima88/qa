using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Old
{
    [SetUpFixture]
    public static class TestLauncher
    {
        [SetUp]
        public static void LaunchTestDirector()
        {
            TestDirector.TestEnvironment = new Dev();
            TestDirector.PrepareBrowser(SeleniumGridServer.Local);
            TestDirector.LogOn();
        }

        [TearDown]
        public static void StopTestDirector()
        {
            TestDirector.LogOff();
            TestDirector.ShutdownBrowser();
        }
    }
}