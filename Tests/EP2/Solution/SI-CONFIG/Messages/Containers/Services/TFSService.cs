using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers.Services
{
    public class TFSService
    {
        public TFSService()
        {
            SetOfTaxFreeServiceProviders = new SetOfTaxfreeServiceProviders();
        }

        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "SetOfTaxfreeServiceProvider")]
        public SetOfTaxfreeServiceProviders SetOfTaxFreeServiceProviders { get; set; }
        
    }
}