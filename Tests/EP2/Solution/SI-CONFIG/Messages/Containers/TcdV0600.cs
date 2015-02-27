using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers
{
	public class TcdV0600 : TcdBase
	{

		[Ep2DataElement(TagName = "CtlessInd", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 1)]
		public int? CtlessInd { get; set; }

		[Ep2DataElement(TagName = "SetCtlessTrmCap", TagPrefix = "ep2", IsMandatory = false)]
		public SetCtlessTrmCap SetCtlessTrmCap { get; set; }

		[Ep2DataElement(TagName = "TrmTrxFctCapExt", TagPrefix = CustomPrefixes.SixPrefix, DataType = Ep2DataType.b, IsMandatory = false, MaxLength = 6)]
		public override byte[] TrmTrxFctCapExt { get; set; }

        [Ep2DataElement(TagName = "TrmTrxFctCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true, MaxLength = 6)]
        public override byte[] TrmTrxFctCap { get; set; }

		public override void Accept(IConfigNotificationVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}