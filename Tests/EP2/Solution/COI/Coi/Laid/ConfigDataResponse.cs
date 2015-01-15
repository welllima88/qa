using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Coi.Laid
{
    [Ep2Message(Ep2MessageNames.ConfigDataResponse)]
    [Ep2Version("0600")]
    public class ConfigDataResponse : IMessage
    {
        [Ep2DataElement]
        public ListAID ListAID { get; set; }

        [Ep2DataElement]
        public int AcqID { get; set; }

        [Ep2DataElement]
        public long SCID { get; set; }
    }
}