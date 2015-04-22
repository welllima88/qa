using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Six.QA.Selenium.Extension.Environment;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Environment;
using Six.Saferpay.QA.Selenium.Pages.Common;

namespace Six.Saferpay.QA.Selenium.Tests
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
            TestDirector.PrepareBrowser(Grid.Local);
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