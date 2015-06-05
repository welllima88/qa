using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers.Services
{
    public class TFSService
    {
        public TFSService()
        {
            SetOfTaxFreeServiceProviders = new SetOfTaxfreeServiceProviders();
        }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "SetOfTaxfreeServiceProvider")]
        public SetOfTaxfreeServiceProviders SetOfTaxFreeServiceProviders { get; set; }
    }
}