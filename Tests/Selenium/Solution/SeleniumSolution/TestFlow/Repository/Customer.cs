namespace Six.Scs.Test.Repository
{
    public class Customer : IRepository
    {
        public static Model.ValueObjects.Customer GetObject()
        {
            return new Model.ValueObjects.Customer
            {
                CustomerNumber = "1"
            };
        }
    }
}