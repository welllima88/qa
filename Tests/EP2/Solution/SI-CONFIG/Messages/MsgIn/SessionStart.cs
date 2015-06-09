using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgIn
{
    [Ep2Message(Ep2MessageNames.SessionStart)]
    public class SessionStart : BaseSIRequest, IamSIMessage
    {
        [Ep2DataElement(DataType = Ep2DataType.n)]
        public int ConfDlMode { get; set; }

        [Ep2DataElement(TagPrefix = "", DataType = Ep2DataType.n)]
        public bool AcqDatChanged { get; set; }
    }

    [Ep2Message(Ep2MessageNames.SessionStart)]
    [Ep2Version("0100")]
    public class SessionStartV01 : BaseSIRequest, IamSIMessage
    {
        [Ep2DataElement(DataType = Ep2DataType.n)]
        public int ConfDlMode { get; set; }

        [Ep2DataElement(TagPrefix = "", DataType = Ep2DataType.n)]
        public bool AcqDatChanged { get; set; }
    }
}