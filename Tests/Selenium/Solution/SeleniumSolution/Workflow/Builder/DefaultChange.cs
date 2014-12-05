using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Workflow.Builder
{
    public class DefaultChange : IPerform
    {
        public void Do()
        {
            ChangeForm.Reason = "Daten Korrektur (ohne Versand)";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " automated change remark";
            // ChangeForm.DelayTime(new TimeSpan().Add(TimeSpan.FromMinutes(1)));
        }

        public void Check()
        {
            // do nothing
        }
    }
}