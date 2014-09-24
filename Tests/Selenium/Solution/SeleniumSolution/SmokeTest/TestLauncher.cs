﻿using NUnit.Framework;
using Six.Scs.QA.Selenium.Environments;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.WebDriver;

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
            TestDirector.PrepareBrowser(SeleniumGridServer.Build);
            TestDirector.LogOn();
        }

        [TearDown]
        public void StopTestDirector()
        {
            TestDirector.Stop();
        }
    }
}