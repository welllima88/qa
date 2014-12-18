using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Coi
{
    [Ep2Message("ep2:cfgstart")]
    [Ep2Version("0530")]
    public class ConfigRequest : IMessage
    {
        [Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int AcqId { get; set; }

        [Ep2DataElement(TagName = "Blah", TagPrefix = "")]
        public string Blah { get; set; }
    }
}