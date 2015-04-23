namespace Six.Scs.QA.Selenium.Model.Repository
{
    public class Customer : IRepository
    {
        public static ValueObjects.Customer GetObject()
        {
            return new ValueObjects.Customer
            {
                CustomerNumber = "1"
            };
        }
    }
}