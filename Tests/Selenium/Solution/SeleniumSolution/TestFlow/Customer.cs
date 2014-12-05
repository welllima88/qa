using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic
{
    public class Customer
    {
        public static CustomerBuilder Edit(CustomerBuilder customerBuilder)
        {
            Open(customerBuilder.Customer);
            customerBuilder.Edit();
            customerBuilder.Check();
            Workflow.Lobby.OpenLatestElement();
            customerBuilder.Check();
            return customerBuilder;
        }

        public static CustomerBuilder Create(CustomerBuilder customerBuilder)
        {
            customerBuilder.Create();
            customerBuilder.Check();
            Workflow.Lobby.OpenLatestElement();
            customerBuilder.Check();
            return customerBuilder;
        }

        public static void Open(TestData.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }
    }
}