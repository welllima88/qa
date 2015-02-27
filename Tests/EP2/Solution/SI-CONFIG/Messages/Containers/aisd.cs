using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers
{

	public static class CustomPrefixes
	{
		public const string SixPrefix = "TKC";
		public const string SixNs = "http://www.six-card-solutions.com";
	}

	public class aisd
	{
		[Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
		public long AcqID { get; set; }

		[Ep2DataElement(TagName = "AcqInitPubKey",  DataType = Ep2DataType.b)]
		public byte[] AcqInitPubKey { get; set; }

		[Ep2DataElement(TagName = "CommAddrAcqInitSrv")]
		public CommAddr CommAddrAcqInitSrv { get; set; }

		[Ep2DataElement(TagName = "MarkupConf", TagPrefix = CustomPrefixes.SixPrefix, IsMandatory = false)]
		public MarkupConf MarkupConf { get; set; }

		[Ep2DataElement(TagName = "FOTrmId", TagPrefix = CustomPrefixes.SixPrefix)]
		public string FOTrmId { get; set; }

		[Ep2DataElement(TagName = "CashSamID", TagPrefix = CustomPrefixes.SixPrefix)]
		public int? CashSamId { get; set; }
	}
}