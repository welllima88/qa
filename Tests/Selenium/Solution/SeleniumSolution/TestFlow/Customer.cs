using NUnit.Framework;
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

        public static void Open(Model.ValueObjects.Customer customer)
        {
            Search.CustomerCanBeFoundByCustomerNumber(customer.CustomerNumber);
        }

        public static void Quit(CustomerBuilder customerBuilder)
        {
            Open(customerBuilder.Customer);
            customerBuilder.Quit();
            customerBuilder.Check();
            Assert.That(View.Customer.View.IsCanceled);
            Assert.That(View.Customer.View.Activate.Displayed);
        }

        public static void Activate(CustomerBuilder customerBuilder)
        {
            Open(customerBuilder.Customer);
            customerBuilder.Activate();

            customerBuilder.Check();
            Assert.That(!View.Customer.View.IsCanceled);
            Assert.That(View.Customer.View.Quit.Displayed);
        }

        /// <summary>
        ///     Moves a given customer in to another customer as a location
        /// </summary>
        /// <param name="customer">the customer which shall be moved</param>
        /// <param name="toCustomer">the target customer</param>
        public static void Move(Model.ValueObjects.Customer customer, Model.ValueObjects.Customer toCustomer)
        {
            Open(customer);
            

            Assert.That(View.Customer.View.Quit.Displayed);
        }
    }
}