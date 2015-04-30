namespace Six.Test.Selenium.Helper
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