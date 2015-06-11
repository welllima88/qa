using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.Workflow.Helper;

namespace Six.Scs.Test.Workflow.Builder
{
    public class Now : IPerform
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