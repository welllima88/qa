using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class CommAddrIp
    {
        /*Internet Addr */

        [Ep2DataElement(TagName = "InternetAddr", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true,
            MaxLength = 64)]
        public string InternetAddr { get; set; }

        /*Internet Port No */

        [Ep2DataElement(TagName = "InternetPortNo", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 5)]
        public string InternetPortNo { get; set; }
    }
}