namespace Six.Scs.QA.Workflow.Builder
{
    public interface IBuilder : ICreate, IEdit, ICheck
    {
        
    }

    public interface ICheck
    {
        void Check();
    }

    public interface IEdit
    {
        void Edit();
    }

    public interface ICreate
    {
        void Create();
    }
}