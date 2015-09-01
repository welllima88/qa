namespace Six.Scs.Test.Repository
{
    public class Customer : IRepository
    {
        public static Model.Customer GetObject()
        {
            return new Model.Customer
            {
                CustomerNumber = "1"
            };
        }
    }
}