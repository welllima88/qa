using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers
{
	public class CtlessTrmCapPerKnl
	{
		[Ep2DataElement(TagName = "CtlessAddTrmCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true)]
		public byte[] CtlessAddTrmCap { get; set; }

		[Ep2DataElement(TagName = "CtlessDataExchangeFlag", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
		public bool CtlessDataExchangeFlag { get; set; }

		[Ep2DataElement(TagName = "CtlessKnlID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
		public string CtlessKnlID { get; set; }

		[Ep2DataElement(TagName = "CtlessKnlVers", TagPrefix = "ep2", DataType = Ep2DataType.ans, MaxLength = 16, IsMandatory = true)]
		public string CtlessKnlVers { get; set; }

		[Ep2DataElement(TagName = "CtlessTrmCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true)]
		public byte[] CtlessTrmCap { get; set; }

		[Ep2DataElement(TagName = "CtlessTrxMode", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
		public int? CtlessTrxMode { get; set; }
	}
}