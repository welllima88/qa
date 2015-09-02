using System;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.Workflow.Helper;

namespace Six.Scs.Test.Workflow
{
    public class DelayedChange : IPerform
    {
        public void Do()
        {
            ChangeForm.Reason = "Daten Korrektur (ohne Versand)";
            ChangeForm.Remark = "SYR automated delayed change remark";
            ChangeForm.DelayTime(new TimeSpan().Add(TimeSpan.FromMinutes(2)));
        }

        public void Check()
        {
            // check nothing for now
        }
    }
}