using Six.Scs.QA.Selenium.Extension.TestData.Factory;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium
{
    public class Customer
    {
        public static CustomerData Edit(CustomerData customer)
        {
            Open(customer);
            CustomerData _customer = CustomerFactory.Edit();
            CustomerService.Edit(_customer);
            CustomerService.Check(_customer);

            LobbyService.OpenLatestElement();
            CustomerService.Check(_customer);
            return _customer;
        }

        public static CustomerData Create()
        {
            CustomerData customer = CustomerFactory.Create();
            CustomerService.Create(customer);
            CustomerService.Check(customer);
            LobbyService.OpenLatestElement();
            CustomerService.Check(customer);
            return customer;
        }

        public static void Open(CustomerData customer)
        {
            SearchService.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }
    }
}