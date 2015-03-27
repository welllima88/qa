using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Testlogic.Builder.Customer.Six;
using Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay;
using Six.Scs.QA.Workflow.Builder;

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

        private static TestData.ValueObjects.Terminal _saferpayTerminal;
        private static CustomerBuilder _saferpayCustomer;
        private static TestData.ValueObjects.Location _saferpayLocation;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal"),
         Category("Saferpay"), Category("ELINK")]
        public static void ElinkCustomerStructure()
        {
            _saferpayCustomer = Testlogic.Customer.Create(new Default());
            _saferpayLocation = Testlogic.Location.Create(_saferpayCustomer.Customer);
            _saferpayTerminal = Testlogic.Terminal.Create(_saferpayLocation,
                new SaferPayPos().With(new Testlogic.Builder.Brand.ELink.Default()));
        }
    }
}