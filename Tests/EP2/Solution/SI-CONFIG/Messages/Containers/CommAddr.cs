using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers 
{
    public class CommAddr
    {

        /*Communication IP Addr */
        [Ep2DataElement(TagName = "CommIpAddr",  TagPrefix = "ep2" , DataType = Ep2DataType.ans ,IsMandatory = true , MaxLength = 64)]
        public string CommIpAddr {get; set;}

        /*Communication IP Port No */
        [Ep2DataElement(TagName = "CommIpPortNo",  TagPrefix = "ep2" , DataType = Ep2DataType.n ,IsMandatory = true , MaxLength = 5)]
        public string CommIpPortNo {get; set;}

        /*Internet Addr */
        [Ep2DataElement(TagName = "InternetAddr",  TagPrefix = "ep2" , DataType = Ep2DataType.ans ,IsMandatory = true , MaxLength = 64)]
        public string InternetAddr {get; set;}

        /*Internet Port No */
        [Ep2DataElement(TagName = "InternetPortNo",  TagPrefix = "ep2" , DataType = Ep2DataType.n ,IsMandatory = true , MaxLength = 5)]
        public string InternetPortNo {get; set;}

        /*Communication No ISDN-B */
        [Ep2DataElement(TagName = "CommNoISDNB",  TagPrefix = "ep2" , DataType = Ep2DataType.n ,IsMandatory = true , MaxLength = 32)]
        public string CommNoISDNB {get; set;}

        /*Communication No PSTN */
        [Ep2DataElement(TagName = "CommNoPSTN",  TagPrefix = "ep2" , DataType = Ep2DataType.n ,IsMandatory = true , MaxLength = 32)]
        public string CommNoPSTN {get; set;}

		[Ep2DataElement(TagName = "CommNoE164", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 32)]
		public string CommNoE164 { get; set; }

        /*Communication No PSTN */
		[Ep2DataElement(TagName = "CommNoX121", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 32)]
		public string CommNoX121 { get; set; }

		

    }
}