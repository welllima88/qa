using Six.QA.Selenium.Extension.Helper;
using Six.Scs.QA.Application.Model.Factory;
using Six.Scs.QA.Application.View.Common;

namespace Six.Scs.QA.Application.Workflow.Builder
{
    public class DefaultChange : IPerform
    {
        public void Do()
        {
            ChangeForm.Reason = "Daten Korrektur (ohne Versand)";
            ChangeForm.Remark = "SYR " + Factory.GenerateTestId() + " automated change remark";
        }

        public void Check()
        {
            // check nothing for now
        }
    }
}