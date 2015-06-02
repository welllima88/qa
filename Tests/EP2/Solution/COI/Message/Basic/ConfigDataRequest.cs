using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Message.Basic
{
    [Ep2Message(Ep2MessageNames.ConfigDataRequest)]
    [Ep2Version("0600")]
    public class ConfigDataRequest : BaseMessage
    {
        [Ep2DataElement(DataType = Ep2DataType.n, IsMandatory = true)]
        public int AcqID { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.n, IsMandatory = true)]
        public string SCID { get; set; }

        //[Ep2DataElement(TagName = "ConfDataObj")]
        [Ep2DataElement]
        public string ConfDataObj { get; set; }
    }
}