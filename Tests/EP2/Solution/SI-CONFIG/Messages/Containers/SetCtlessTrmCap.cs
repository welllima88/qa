using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class SetCtlessTrmCap
    {
        public SetCtlessTrmCap()
        {
            CtlessTrmCapPerKnl = new List<CtlessTrmCapPerKnl>();
        }

        [Ep2DataElement(TagName = "CtlessTrmCapPerKnl", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false
            )]
        public IList<CtlessTrmCapPerKnl> CtlessTrmCapPerKnl { get; set; }
    }
}