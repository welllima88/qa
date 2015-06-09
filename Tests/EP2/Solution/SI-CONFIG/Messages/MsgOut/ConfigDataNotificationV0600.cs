using Six.Scs.Ep2.SI.Config.Messages.Containers;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgOut
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