using System;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Common;
using Six.Test.Selenium.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public class DelayedChange : IPerform
    {
        public void Do()
        {
            ChangeForm.Reason = "Daten Korrektur (ohne Versand)";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " automated delayed change remark";
            ChangeForm.DelayTime(new TimeSpan().Add(TimeSpan.FromMinutes(2)));
        }

        public void Check()
        {
            // check nothing for now
        }
    }
}