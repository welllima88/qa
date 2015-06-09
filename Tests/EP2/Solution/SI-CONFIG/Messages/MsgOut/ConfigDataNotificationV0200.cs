using Six.Scs.Ep2.SI.Config.Messages.Containers;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgOut
{
    [Ep2Message(Ep2MessageNames.ConfigDataNotification)]
    public class ConfigDataNotificationV0200 : ConfigDataNotificationBase
    {
        public ConfigDataNotificationV0200()
        {
            tcd = new TcdV0200();
        }

        [Ep2DataElement(TagName = "tcd")]
        public TcdV0200 tcd { get; set; }

        public override void Accept(IConfigNotificationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}