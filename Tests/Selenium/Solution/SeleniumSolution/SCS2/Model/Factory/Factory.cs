using System;

namespace Six.Scs.QA.Application.Model.Factory
{
    public static class Factory
    {
        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}