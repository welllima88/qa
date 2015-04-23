using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Workflow.Builder;
using Six.Scs.QA.Testlogic.Builder.Customer.Six;
using Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay;

namespace Six.Scs.QA.Selenium.SystemTest.Saferpay
{
    [TestFixture]
    public class ELinkTest
    {
        [SetUp]
        public static void TestInit()
        {
            TestDirector.Navigate();
        }

        private static Model.ValueObjects.Terminal _saferpayTerminal;
        private static CustomerBuilder _saferpayCustomer;
        private static LocationBuilder _saferpayLocation;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal"),
         Category("Saferpay"), Category("ELINK")]
        public static void ElinkCustomerStructure()
        {
            _saferpayCustomer = Testlogic.Customer.Create(new Default());
            _saferpayLocation = Testlogic.Location.Create(_saferpayCustomer.Customer, new Testlogic.Builder.Location.Default());
            _saferpayTerminal = Testlogic.Terminal.Create(_saferpayLocation.Location,
                new SaferPayPos().With(new Testlogic.Builder.Brand.ELink.Default()));
        }
    }
}