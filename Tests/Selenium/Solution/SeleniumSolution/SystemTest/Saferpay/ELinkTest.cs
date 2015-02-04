using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
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
        private static CustomerBuilder _saferpay;

        [Test]
        [Category("Regression"), Category("Customer"), Category("Location"), Category("Terminal"),
         Category("Saferpay"), Category("ELINK")]
        public static void ElinkCustomerStructure()
        {
            _saferpay = Testlogic.Customer.Create(new Default());
            _saferpayTerminal = Testlogic.Terminal.Create(_saferpay.Customer,
                new SaferPayPos().With(new Testlogic.Builder.Brand.ELink.Default()));
        }
    }
}