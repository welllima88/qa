using System;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test
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

        public static void Create(Model.Terminal terminal, BrandBuilder brandBuilder)
        {
            Terminal.Open(terminal);

            BrandPortlet.NewBrandButton.Click();

            brandBuilder.Create();
            brandBuilder.Check();
        }
    }
}