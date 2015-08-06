﻿using NUnit.Framework;
using Six.Scs.Test.View.Search;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Search.Terminal
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ByIdTest
    {
        private static string _terminal;

        [TestFixtureSetUp]
        [Category("Search")]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void Ep2TerminalId()
        {
            _terminal = "30092755";
            Workflow.Search.Find(_terminal);
            SearchResult.First(Result.Terminal).Click();

            Assert.That(TerminalInfo.TerminalId, Is.EqualTo(_terminal));
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void IfsfGroupAndDeviceTerminalId()
        {
            _terminal = "06081588";
            Workflow.Search.Find(_terminal);
            SearchResult.First(Result.Terminal).Click();

            Assert.That(TerminalInfo.ExternTerminalId, Is.EqualTo(_terminal));
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void IfsfGroupTerminalId()
        {
            _terminal = "060815";
            Workflow.Search.Find(_terminal);
            SearchResult.First(Result.Terminal).Click();

            Assert.That(TerminalInfo.ExternTerminalId, Is.StringStarting(_terminal));
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void ScsTerminalId()
        {
            _terminal = "06081588";
            Workflow.Search.Find(_terminal);
            SearchResult.First(Result.Terminal).Click();

            Assert.That(TerminalInfo.ExternTerminalId, Is.EqualTo("06081588"));
        }
    }
}