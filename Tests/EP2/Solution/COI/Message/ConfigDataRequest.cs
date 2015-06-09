using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message
{
    [Ep2Message(Ep2MessageNames.ConfigDataRequest)]
    [Ep2Version("0600")]
    public class ConfigDataRequest : BaseMessage
    {
        [Ep2DataElement(TagName = "AcqID", DataType = Ep2DataType.n, IsMandatory = true)]
        public int AcqId { get; set; }

        [Ep2DataElement(TagName = "SCID", DataType = Ep2DataType.n, IsMandatory = true)]
        public string ScId { get; set; }

        //[Ep2DataElement(TagName = "ConfDataObj")]
        [Ep2DataElement]
        public string ConfDataObj { get; set; }
    }
}