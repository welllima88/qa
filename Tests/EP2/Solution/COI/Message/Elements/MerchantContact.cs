using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message.Elements
{
    [Ep2DataElement(TagName = "MctCctAddr", TagPrefix = "ep2")]
    public class MerchantContact

    {
        [Ep2DataElement(TagName = "MctCctFrstN ", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCctFrstN { get; set; }

        [Ep2DataElement(TagName = "MctCctFamN", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCctFamN { get; set; }

        [Ep2DataElement(TagName = "MctCity", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCity { get; set; }

        [Ep2DataElement(TagName = "MctCntryCode", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCntryCode { get; set; }

        [Ep2DataElement(TagName = "MctCompName", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCompName { get; set; }

        [Ep2DataElement(TagName = "MctEMail", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctEMail { get; set; }

        [Ep2DataElement(TagName = "MctPBox", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctPBox { get; set; }

        [Ep2DataElement(TagName = "MctPC", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctPC { get; set; }

        [Ep2DataElement(TagName = "MctPhone", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctPhone { get; set; }

        [Ep2DataElement(TagName = "MctMobile", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctMobile { get; set; }

        [Ep2DataElement(TagName = "MctStreetNum", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctStreetNum { get; set; }
    }
}