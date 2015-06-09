using SIX.EP2.Core.ContentHandling;

namespace Six.Scs.Ep2.SI.Config.Messages
{
    public interface IamSIMessage : IMessage
    {
        string TrmID { get; set; }
        long SCID { get; set; }
        int? MsgNum { get; set; }
    }
}