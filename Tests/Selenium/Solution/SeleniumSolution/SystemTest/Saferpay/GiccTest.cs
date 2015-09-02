using NUnit.Framework;
using Six.Scs.Test.Builder.Customer.Nsp;
using Six.Scs.Test.Builder.Location;
using Six.Scs.Test.Builder.Terminal.Saferpay;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium.WebDriver;
using Default = Six.Scs.Test.Builder.Brand.Gicc.Default;

namespace Six.Scs.Test.Saferpay
{
    [TestFixture]
    public class GiccTest
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
        [Category("Regression")]
        [Category("Customer")]
        [Category("Location")]
        [Category("Terminal")]
        [Category("Saferpay")]
        [Category("GICC")]
        public static void GiccCustomerStructure()
        {
            _saferpayCustomer = Customer.Create(new SixNsp(Factory.Customer.Create()));
            _saferpayLocation = Location.Create(_saferpayCustomer.Customer, new Gicc(Factory.Location.Create()));
            _saferpayTerminal = Terminal.Create(_saferpayLocation.Location,
                new Icp().With(new Default()));
        }
    }
}