using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Common
{
    [Ep2Message(Ep2MessageNames.ConfigDataRequest)]
    [Ep2Version("0600")]
    public class ConfigDataRequest : IMessage
    {
        [Ep2DataElement(TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int AcqID { get; set; }

        [Ep2DataElement(TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string SCID { get; set; }

        [Ep2DataElement(TagPrefix = "ep2", DataType = Ep2DataType.uan, IsMandatory = true)]
        public string ConfDataObj { get; set; }
    }
}