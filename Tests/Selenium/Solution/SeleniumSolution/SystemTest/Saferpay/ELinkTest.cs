using NUnit.Framework;
using Six.Scs.Test.Builder.Customer.Six;
using Six.Scs.Test.Builder.Terminal.Saferpay;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Saferpay
{
    [TestFixture]
    public class ELinkTest
    {
        [SetUp]
        public static void TestInit()
        {
            TestDirector.Navigate();
        }

        private static Model.Terminal _saferpayTerminal;
        private static CustomerBuilder _saferpayCustomer;
        private static LocationBuilder _saferpayLocation;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal"),
         Category("Saferpay"), Category("ELINK")]
        public static void ElinkCustomerStructure()
        {
            _saferpayCustomer = Customer.Create(new Default());
            _saferpayLocation = Location.Create(_saferpayCustomer.Customer, new Builder.Location.Default(Model.Factory.Location.Create()));
            _saferpayTerminal = Terminal.Create(_saferpayLocation.Location,
                new SaferPayPos().With(new Builder.Brand.ELink.Default()));
            // TODO new Quit for all terminals is only active for Saferpay by now wait until it is system wide, then enable both:
            // Terminal.Quit(_saferpayTerminal); 
            // Customer.Quit(_saferpayCustomer);
        }
    }
}