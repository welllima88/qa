using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgIn
{
    [Ep2Message(Ep2MessageNames.ResetTerminalAcknowledge)]
    public class ResetTerminalAcknowledge : BaseSIRequest, IamSIMessage
    {
    }
}