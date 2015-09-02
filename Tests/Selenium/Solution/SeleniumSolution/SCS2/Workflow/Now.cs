using Six.Scs.Test.UI.Common;
using Six.Scs.Test.Workflow.Helper;

namespace Six.Scs.Test.Workflow
{
    public class Now : IPerform
    {
        public void Do()
        {
            ChangeForm.Reason = "Daten Korrektur (ohne Versand)";
            ChangeForm.Remark = "SYR automated change remark";
        }

        public void Check()
        {
            // check nothing for now
        }
    }
}