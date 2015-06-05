using Six.Scs.Ep2.SI.Config.Messages.Containers;
using Six.Scs.Ep2.SI.Config.Messages.MsgOut;

namespace Six.Scs.Ep2.SI.Config.Messages
{
    public interface IConfigNotificationVisitor
    {
        void Visit(ConfigDataNotificationV0200 ntf);
        void Visit(ConfigDataNotificationV0600 ntf);
        void Visit(ConfigDataNotificationV0500 ntf);
        void Visit(ConfigDataNotificationV0531 ntf);
        void Visit(TcdV0200 ntf);
        void Visit(TcdV0500 ntf);
        void Visit(TcdV0531 ntf);
        void Visit(TcdV0600 ntf);
    }
}