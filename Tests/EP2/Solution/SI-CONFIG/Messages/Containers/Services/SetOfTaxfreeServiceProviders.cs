using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers.Services
{
    public class SetOfTaxfreeServiceProviders
    {
        public SetOfTaxfreeServiceProviders()
        {
            TaxFreeServiceProviders = new List<TaxFreeServiceProvider>();
        }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "TaxFreeServiceProvider")]
        public IList<TaxFreeServiceProvider> TaxFreeServiceProviders { get; set; }
    }
}