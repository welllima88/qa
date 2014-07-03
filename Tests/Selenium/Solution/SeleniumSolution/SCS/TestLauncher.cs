using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium
{
    [SetUpFixture]
    public static class TestLauncher
    {
        [SetUp]
        public static void LaunchTestDirector(TestContext testContext)
        {
            ScsClassicEnvironment.Dev();
            TestDirector.PrepareBrowser();
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