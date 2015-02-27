using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.EP2.SIConfig.Host.Messages.Containers;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgOut
{
	[Ep2Version("0520")]
	[Ep2Message(Ep2MessageNames.ConfigDataNotification)]
	public class ConfigDataNotificationV0500 : ConfigDataNotificationBase
	{
		public ConfigDataNotificationV0500()
		{
			tcd = new TcdV0500();
		}

		[Ep2DataElement(TagName = "tcd")]
		public TcdV0500 tcd { get; set; }

		public override void Accept(IConfigNotificationVisitor visitor)
		{
			visitor.Visit(this);
			
		}
	}
}
