using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.QA.Tests.EP2.Laid;
using SIX.SCS.QA.Tests.EP2.Message.Elements;

namespace SIX.SCS.QA.Tests.EP2.Message
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