using System;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message.Elements
{
    [Ep2DataElement(TagName = "ad")]
    public class Ad : IConfigDataObject
    {
        [Ep2DataElement(TagName = "MctID", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctID { get; set; }

        [Ep2DataElement(TagName = "AdminRem", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string AdminRem { get; set; }

        [Ep2DataElement(TagName = "ActDate", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string ActDate { get; set; }

        [Ep2DataElement(TagName = "DataStatus", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public int? DataStatus { get; set; }

        [Ep2DataElement(TagName = "DataLastChDate", TagPrefix = "ep2", DataType = Ep2DataType.date, IsMandatory = false)
        ]
        public DateTime? DataLastChDate { get; set; }

        [Ep2DataElement(TagName = "MctCctAddr", TagPrefix = "ep2")]
        public MerchantContact MctCctAddr { get; set; }

        [Ep2DataElement(TagName = "MctNameLoc", TagPrefix = "ep2")]
        public MerchantNameLocation MctNameLoc { get; set; }
    }
}