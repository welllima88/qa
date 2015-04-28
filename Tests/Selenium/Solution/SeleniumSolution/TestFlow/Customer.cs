using Six.Scs.QA.Application.Workflow;
using Six.Scs.QA.Application.Workflow.Builder;

namespace Six.Scs.QA.Testlogic
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

        public static void Open(Application.Model.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }
    }
}