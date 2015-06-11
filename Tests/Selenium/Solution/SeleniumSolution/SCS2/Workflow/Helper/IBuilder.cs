using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Workflow.Helper
{
    public abstract class Builder : ICreate, IEdit, ICheck
    {

        public abstract void Create();
        public abstract void Edit();
        public abstract void Check();
    }
}