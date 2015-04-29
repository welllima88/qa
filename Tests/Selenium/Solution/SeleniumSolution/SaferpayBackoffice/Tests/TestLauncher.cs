using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Six.Saferpay.Backoffice.Test.Environment;
using Six.Saferpay.Backoffice.Test.Pages.Common;
using Six.Test.Selenium.Environment;
using Six.Test.Selenium.WebDriver;

namespace Six.Saferpay.Backoffice.Test.Tests
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

            PageFactory.InitElements(TestDirector.WebDriver, TestDirector.TestEnvironment.Application);
            Assert.IsTrue(MetaNavBar.LogOff.Displayed);
        }

        [TearDown]
        public void StopTestDirector()
        {
            TestDirector.Stop();
        }
    }
}