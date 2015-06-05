using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class Aisd
    {
        [Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public long AcqID { get; set; }

        [Ep2DataElement(TagName = "AcqInitPubKey")]
        public string AcqInitPubKey { get; set; }

        [Ep2DataElement(TagName = "CommAddrAcqInitSrv")]
        public CommAddr CommAddrAcqInitSrv { get; set; }
    }
}