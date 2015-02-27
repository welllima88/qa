using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers.Services
{
    public class TaxFreeServiceProvider
    {
        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "TaxFreeProvidername", MaxLength = 18)]
        public string TaxFreeProvidername { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "TaxFreeServiceProviderId", MaxLength = 4)]
		public int TaxFreeServiceProviderId { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "CommAddrServiceHost")]
        public CommAddrServHost CommAddrServiceHost { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "SetOfTaxFreeCertificatePinned")]
		public SetOfTaxFreeCertificatePinned SetOfTaxFreeCertificatePinned { get; set; }
    }

	public class SetOfTaxFreeCertificatePinned
	{
		public SetOfTaxFreeCertificatePinned()
		{
			TaxFreeCertificateFingerprint = new List<byte[]>();
		}

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, TagName = "TaxFreeCertificateFingerprint")]
		public IList<byte[]> TaxFreeCertificateFingerprint { get; set; }
	}
}