using System;

namespace Six.Scs.Test.Model.Factory
{
    public static class Factory
    {
        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}