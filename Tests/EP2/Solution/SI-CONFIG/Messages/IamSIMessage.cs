using SIX.EP2.Core.ContentHandling;

namespace SIX.SCS.EP2.SIConfig.Host.Messages
{
	public interface IamSIMessage : IMessage
	{
		string TrmID { get; set; }
		long SCID { get; set; }
		int? MsgNum { get; set; }
	}
}