using NUnit.Framework;
using Six.Scs.Test.View.AcquirerExchange;
using Six.Scs.Test.View.Massmuation;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test.Builder.Acquirer
{
    public class Default : AcquirerExchange
    {
        public override void Check()
        {
            BrandPortlet.ExpandAll();
            Assert.That(Progress.BatchId, Is.GreaterThan(0));
        }

        protected override void SetupBrands()
        {
            var brands = View.AcquirerExchange.View.AcquirerElement("acq_multipay").Brands();
            foreach (var brandElement in brands)
            {
                brandElement.Selected.Set(true);
                brandElement.NewBrand.SelectByText("SIX Payment Services (Europe)");
                brandElement.DccProvider.SelectByText("SIX Payment Services");
                brandElement.Mcc.SelectByText("2343");
                // brandElement.ContractNumber.TypeText("??");
            }
        }
    }
}