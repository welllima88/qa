using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers.Services
{
    public class TaxFreeServiceProvider
    {
        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "TaxFreeProvidername", MaxLength = 18)]
        public string TaxFreeProvidername { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "TaxFreeServiceProviderId", MaxLength = 4)]
        public int TaxFreeServiceProviderId { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "CommAddrServiceHost")]
        public CommAddrServHost CommAddrServiceHost { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "SetOfTaxFreeCertificatePinned")]
        public SetOfTaxFreeCertificatePinned SetOfTaxFreeCertificatePinned { get; set; }
    }

    public class SetOfTaxFreeCertificatePinned
    {
        public SetOfTaxFreeCertificatePinned()
        {
            TaxFreeCertificateFingerprint = new List<byte[]>();
        }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, TagName = "TaxFreeCertificateFingerprint")]
        public IList<byte[]> TaxFreeCertificateFingerprint { get; set; }
    }
}