using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.EP2.SIConfig.Host.Messages.Containers;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgOut
{
	[Ep2Message(Ep2MessageNames.ConfigDataNotification)]
	public class ConfigDataNotificationV0531 : ConfigDataNotificationBase
	{
		public ConfigDataNotificationV0531()
		{
			tcd = new TcdV0531();
		}

		[Ep2DataElement(TagName = "tcd")]
		public TcdV0531 tcd { get; set; }

		public override void Accept(IConfigNotificationVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}