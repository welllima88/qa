using Six.Scs.Ep2.Coi.Message.Elements;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message
{
    [Ep2Message(Ep2MessageNames.ConfigDataResponse)]
    [Ep2Version("0600")]
    public class ConfigDataResponse : IMessage
    {
        [Ep2DataElement(TagName = "ListAID")]
        public ListAID ListAid { get; set; }

        [Ep2DataElement(TagName = "AISD")]
        public ListAID Aisd { get; set; }

        [Ep2DataElement(TagName = "AcqID")]
        public int AcqId { get; set; }

        [Ep2DataElement(TagName = "SCID")]
        public long Scid { get; set; }
    }
}