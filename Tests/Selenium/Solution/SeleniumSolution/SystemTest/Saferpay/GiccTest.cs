using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Testlogic.Builder.Brand.Gicc;
using Six.Scs.QA.Testlogic.Builder.Customer.Nsp;
using Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Selenium.SystemTest.Saferpay
{
    [TestFixture]
    public class GiccTest
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
         Category("Saferpay"), Category("GICC")]
        public static void GiccCustomerStructure()
        {
            _saferpay = Testlogic.Customer.Create(new SixNsp());
            _saferpayTerminal = Testlogic.Terminal.Create(_saferpay.Customer,
                new Icp().With(new Default()));
        }
    }
}