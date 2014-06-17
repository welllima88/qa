using System;

namespace Six.Scs.Tests.Selenium.Extension.TestData
{
    public static class Factory
    {
        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}