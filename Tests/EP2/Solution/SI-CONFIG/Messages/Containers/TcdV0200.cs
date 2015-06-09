using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class TcdV0200 : TcdBase
    {
        [Ep2DataElement(TagName = "AutoDataSubm", DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 1)]
        public bool? AutoDataSubm { get; set; }

        [Ep2DataElement(TagName = "AutoDataTrans", TagPrefix = "ep2", DataType = Ep2DataType.n, MaxLength = 1)]
        public int? AutoDataTrans { get; set; }

        public override void Accept(IConfigNotificationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}