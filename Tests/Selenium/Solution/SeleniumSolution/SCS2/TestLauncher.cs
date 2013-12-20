using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;

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
            KillFirefoxProcesses();

            ScsPlatinTestEnvironment.LoadConfigurationDev();
            TestDirector.PrepareBrowser();
            TestDirector.Login();
        }

        [AssemblyCleanup]
        public static void StopTestDirector()
        {
            TestDirector.Logout();
            TestDirector.ShutDownBrowser();

            KillFirefoxProcesses();
        }

        private static void KillFirefoxProcesses()
        {
            IEnumerable<Process> processes = Process.GetProcesses().Where(p => p.ProcessName.Contains("firefox"));

            foreach (Process process in processes)
            {
                Debug.WriteLine("ID: {0} Name: {1} Threads: {2}", process.Id, process.ProcessName,
                                process.Threads.Count);
                process.Kill();
            }
        }
    }
}