using System;

namespace TestData.Factory
{
    public static class Factory
    {
        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}