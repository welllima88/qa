using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgOut
{
    [Ep2Version("0520")]
    [Ep2Message(Ep2MessageNames.ConfigDataRequest)]
    public class ConfigDataRequest : BaseMessage, IamSIMessage
    {
        [Ep2DataElement(TagName = "ConfDataObj")]
        public string ConfDataObj { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.n)]
        public long SCID { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.an8)]
        public string TrmID { get; set; }
    }
}