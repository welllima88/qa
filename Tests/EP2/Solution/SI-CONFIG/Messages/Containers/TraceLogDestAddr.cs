using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class TraceLogDestAddr
    {
        /*Port Address for Communication Over ISDN or PSTN */

        [Ep2DataElement(TagName = "TraceLogCommPortNo", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 5)]
        public string TraceLogCommPortNo { get; set; }

        /*IP Address for Communication Over ISDN or PSTN */

        [Ep2DataElement(TagName = "TraceLogCommIpAddr", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.ans,
            IsMandatory = false, MaxLength = 64)]
        public string TraceLogCommIpAddr { get; set; }

        /*Phone Number for ISDN */

        [Ep2DataElement(TagName = "TraceLogCommNoISDNB", TagPrefix = CustomPrefixes.Six,
            DataType = Ep2DataType.ans, IsMandatory = false, MaxLength = 32)]
        public string TraceLogCommNoISDNB { get; set; }

        /*Phone Number for PSTN */

        [Ep2DataElement(TagName = "TraceLogCommNoPSTN", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.ans,
            IsMandatory = false, MaxLength = 32)]
        public string TraceLogCommNoPSTN { get; set; }

        /*Destination Address */

        [Ep2DataElement(TagName = "TraceLogInternetAddr", TagPrefix = CustomPrefixes.Six,
            DataType = Ep2DataType.ans, IsMandatory = false, MaxLength = 64)]
        public string TraceLogInternetAddr { get; set; }

        /*Destination Port */

        [Ep2DataElement(TagName = "TraceLogInternetPortNo", TagPrefix = CustomPrefixes.Six,
            DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 5)]
        public string TraceLogInternetPortNo { get; set; }
    }
}