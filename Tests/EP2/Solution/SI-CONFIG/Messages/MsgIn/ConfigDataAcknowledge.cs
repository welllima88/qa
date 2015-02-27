using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgIn
{
	[Ep2Message(Ep2MessageNames.ConfigDataAcknowledgement)]
    public class ConfigDataAcknowledge : BaseSIRequest, IamSIMessage
    {
    }
}