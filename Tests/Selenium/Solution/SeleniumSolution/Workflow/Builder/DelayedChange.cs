using System;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Workflow.Builder
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