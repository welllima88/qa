using System;

namespace Six.Scs.QA.Workflow
{
    public abstract class TerminalBuilder
    {
        public void ChooseArticle()
        {
            throw new NotImplementedException();
        }

        public abstract void SetBasics();

        public abstract void SetDetails();
    }
}