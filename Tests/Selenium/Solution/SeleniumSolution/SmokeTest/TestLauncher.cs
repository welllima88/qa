﻿using NUnit.Framework;
using Six.QA.Selenium.Extension.Environment;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Environments;

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
            TestDirector.TestEnvironment = new Dev();
            TestDirector.PrepareBrowser(Grid.Build);
            TestDirector.Start();
        }

        [TearDown]
        public void StopTestDirector()
        {
            TestDirector.Stop();
        }

        [TearDown]
        public void LoginSuccessful()
        {
            Assert.IsTrue(MetaNavBar.LogOff.Displayed);
        }
    }
}