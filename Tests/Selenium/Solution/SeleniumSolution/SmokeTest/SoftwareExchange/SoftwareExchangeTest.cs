﻿using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Application.SmokeTest.SoftwareExchange
{
    [TestFixture]
    public class SoftwareExchangeTest
    {
        [SetUp]
        public void TestInit()
        {
        }

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("MasterSoftwareExchange/");
        }
    }
}