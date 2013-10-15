﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium
{
    /// <summary>
    ///     The TestLauncher prepares Browser with TestDirector and keeps this
    /// </summary>
    [TestClass]
    public static class TestLauncher
    {

        public static long GenerateTestId()
        {
            return DateTime.Now.Ticks;
        }

        [AssemblyInitialize]
        public static void LaunchTestDirector(TestContext testContext)
        {
            ScsPlatinTestEnvironment.LoadConfigurationDev();
            TestDirector.PrepareBrowser();
            TestDirector.Login();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.Logout();
            TestDirector.ShutDownBrowser();
        }
    }
}