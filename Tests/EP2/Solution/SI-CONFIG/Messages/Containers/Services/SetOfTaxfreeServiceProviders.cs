using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers.Services
{
    public class SetOfTaxfreeServiceProviders
    {
        public SetOfTaxfreeServiceProviders()
        {
            TaxFreeServiceProviders = new List<TaxFreeServiceProvider>();
        }

        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "TaxFreeServiceProvider")]
        public IList<TaxFreeServiceProvider> TaxFreeServiceProviders { get; set; }
    }
}