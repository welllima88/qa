using Six.Scs.Test.Workflow;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test
{
    public class Customer
    {
        public static CustomerBuilder Edit(CustomerBuilder customerBuilder)
        {
            Open(customerBuilder.Customer);
            customerBuilder.Edit();
            customerBuilder.Check();
            Lobby.OpenLatestElement();
            customerBuilder.Check();
            return customerBuilder;
        }

        public static CustomerBuilder Create(CustomerBuilder customerBuilder)
        {
            customerBuilder.Create();
            customerBuilder.Check();
            Lobby.OpenLatestElement();
            customerBuilder.Check();
            return customerBuilder;
        }

        public static void Open(Test.Model.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }
    }
}