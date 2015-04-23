using System;
using Six.QA.Selenium.Extension.Helper;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.View.Common;

namespace Six.Scs.QA.Selenium.Workflow.Builder
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