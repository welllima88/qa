using NUnit.Framework;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Environments;
using Six.Test.Selenium.Environment;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test
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
            TestDirector.TestEnvironment = new Dev();
            TestDirector.PrepareBrowser(Grid.Build);
            TestDirector.Start();

            Assert.IsTrue(MetaNavBar.LogOff.Displayed);
        }

        [TearDown]
        public void StopTestDirector()
        {
            TestDirector.Stop();
        }
    }
}