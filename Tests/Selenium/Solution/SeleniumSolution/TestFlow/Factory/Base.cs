using System;

namespace Six.Scs.Test.Factory
{
    public static class Base
    {
        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}