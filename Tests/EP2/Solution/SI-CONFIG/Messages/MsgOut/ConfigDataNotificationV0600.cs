using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.EP2.SIConfig.Host.Messages.Containers;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgOut
{
    [Ep2Message(Ep2MessageNames.ConfigDataNotification)]
	public class ConfigDataNotificationV0600 : ConfigDataNotificationBase
    {
	    public ConfigDataNotificationV0600()
	    {
			tcd = new TcdV0600();
	    }
		
        [Ep2DataElement(TagName = "tcd")]
		public TcdV0600 tcd { get; set; }


	    public override void Accept(IConfigNotificationVisitor visitor)
	    {
			visitor.Visit(this);
	    }
    }
}