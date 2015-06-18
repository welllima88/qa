using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message.Elements
{
    [Ep2DataElement(TagName = "MctNameLoc", TagPrefix = "ep2")]
    public class MerchantNameLocation
    {
        [Ep2DataElement(TagName = "MctAddInfo", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctAddInfo { get; set; }

        [Ep2DataElement(TagName = "MctCity", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCity { get; set; }

        [Ep2DataElement(TagName = "MctCntryCode", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCntryCode { get; set; }

        [Ep2DataElement(TagName = "MctCompName", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctCompName { get; set; }

        [Ep2DataElement(TagName = "MctPBox", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctPBox { get; set; }

        [Ep2DataElement(TagName = "MctPC", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctPC { get; set; }

        [Ep2DataElement(TagName = "MctStreetName", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctStreetName { get; set; }

        [Ep2DataElement(TagName = "MctStreetNum", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctStreetNum { get; set; }
    }
}