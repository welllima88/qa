using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers
{
	public class TcdV0500 : TcdBase
	{
		/*Contactless Indicator */
		[Ep2DataElement(TagName = "CtlessInd", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 1)]
		public int? CtlessInd { get; set; }

		public override void Accept(IConfigNotificationVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}