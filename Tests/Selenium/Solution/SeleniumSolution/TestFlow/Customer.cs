using Six.Scs.QA.Selenium.Workflow;
using Six.Scs.QA.Selenium.Workflow.Builder;

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

        public static void Open(Selenium.Model.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }
    }
}