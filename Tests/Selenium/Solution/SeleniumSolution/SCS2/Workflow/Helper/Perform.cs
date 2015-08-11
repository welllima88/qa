namespace Six.Scs.Test.Workflow.Helper
{
    public abstract class Perform : IPerform
    {
        public abstract void Check();
        public abstract void Do();
    }
}