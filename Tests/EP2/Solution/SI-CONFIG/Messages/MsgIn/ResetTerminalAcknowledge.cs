using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgIn
{
    [Ep2Message(Ep2MessageNames.ResetTerminalAcknowledge)]
	public class ResetTerminalAcknowledge : BaseSIRequest, IamSIMessage
    {
    }
}