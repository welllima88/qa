using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgOut
{
    [Ep2Version("0520")]
    [Ep2Message(Ep2MessageNames.ActivateConfigDataNotification)]
    public class ActivateConfigNotification : BaseMessage, IamSIMessage
    {
        [Ep2DataElement(TagName = "TrmID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string TrmID { get; set; }

        [Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public long SCID { get; set; }
    }
}