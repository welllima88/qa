using System;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic
{
    public class Brands
    {
        private static void CheckBrands()
        {
            ContractsExist();
            TicketsCreated();
        }

        private static void TicketsCreated()
        {
            Console.Out.WriteLine(@"Checking Tickets");
        }

        private static void ContractsExist()
        {
        }

        public static void Create(Selenium.Model.ValueObjects.Terminal terminal, BrandBuilder brandBuilder)
        {
            Terminal.Open(terminal);

            BrandPortlet.NewBrandButton.Click();

            brandBuilder.Create();
            brandBuilder.Check();
        }
    }
}