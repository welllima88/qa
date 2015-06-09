using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgIn
{
    [Ep2Version("0201")]
    [Ep2Version("0300")]
    [Ep2Version("0310")]
    [Ep2Version("0400")]
    [Ep2Version("0410")]
    [Ep2Version("0500")]
    [Ep2Version("0501")]
    [Ep2Version("0510")]
    [Ep2Version("0520")]
    [Ep2Version("0530")]
    [Ep2Version("0531")]
    [Ep2Version("0600")]
    public abstract class BaseSIRequest : IMessageWithNum
    {
        [Ep2DataElement(TagName = "TrmID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string TrmID { get; set; }

        [Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public long SCID { get; set; }

        public int? MsgNum { get; set; }
    }
}