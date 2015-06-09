using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class MarkupConf
    {
        /*Neues Tag DCCProvider */

        [Ep2DataElement(TagName = "DCCProvider", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false,
            MaxLength = 1)]
        public int? DCCProvider { get; set; }

        /*Neues Tag DccAuthPubKey */

        [Ep2DataElement(TagName = "DccAuthPubKey", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.b,
            IsMandatory = false, MaxLength = 283)]
        public byte[] DccAuthPubKey { get; set; }

        /*Neues Tag ToDccProvider */

        [Ep2DataElement(TagName = "ToDccProvider", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 4)]
        public int? ToDccProvider { get; set; }

        /*Neues Tag Ep2CommSecureMarkup */

        [Ep2DataElement(TagName = "Ep2CommSecureMarkup", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 4)]
        public int? Ep2CommSecureMarkup { get; set; }

        /*Neues Tag CommAddrDCCInq */

        [Ep2DataElement(TagName = "CommAddrDCCInq", TagPrefix = "ep2", IsMandatory = false)]
        public CommAddr CommAddrDCCInq { get; set; }
    }
}