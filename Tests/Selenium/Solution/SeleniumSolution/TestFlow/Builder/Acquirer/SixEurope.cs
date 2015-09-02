using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Six.Scs.Test.View.Massmuation;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test.Builder.Acquirer
{
    public class SixEurope : AcquirerExchange
    {
        public override void Check()
        {
            Batch.WaitForBatchHasFinished();
            Assert.That(Progress.BatchId, Is.Not.Empty);
        }

        protected override Collection<string> SetupBrands()
        {
            var brandIdsWithChange = new Collection<string>();
            var brands = View.AcquirerExchange.View.AcquirerElement("acq_multipay").Brands();
            foreach (var brandElement in brands)
            {
                if (brandElement.Name.Text.Contains("Maestro-CH")) break;

                brandElement.Selected.Set(true);
                brandElement.NewBrand.SelectByText("SIX Payment Services (Europe)");
                brandElement.DccProvider.SelectByText("SIX Payment Services");
                brandElement.Mcc.SelectByText("2343");
                brandElement.ContractNumber.TypeText("100007761");
                brandIdsWithChange.Add(brandElement.Id);
            }
            brands = View.AcquirerExchange.View.AcquirerElement("acq_amexco").Brands();
            foreach (var brandElement in brands)
            {
                brandElement.Selected.Set(true);
                brandElement.NewBrand.SelectByText("American Express AT und DE ep2 [1178]");
                brandElement.Mcc.SelectByText("SERVICE STATIONS");
                brandElement.ContractNumber.TypeText("168800901");
                brandIdsWithChange.Add(brandElement.Id);
            }
            return brandIdsWithChange;
        }
    }
}