using System.Collections.Generic;
using Six.Scs.Ep2.SI.Config.Messages.Containers;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgOut
{
    public abstract class ConfigDataNotificationBase : IMessageWithNum, IamSIMessage
    {
        [Ep2DataElement(TagName = "aisd")]
        public IList<Aisd> Aisd { get; set; }

        [Ep2DataElement(TagName = "TrmID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string TrmID { get; set; }

        [Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public long SCID { get; set; }

        public int? MsgNum { get; set; }
        public abstract void Accept(IConfigNotificationVisitor visitor);
    }
}