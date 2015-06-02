using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.EP2.SIConfig.Host.Messages.Containers;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.MsgIn
{
    [Ep2Message(Ep2MessageNames.ConfigDataResponse)]
    public class ConfigDataResponse : BaseSIRequest, IamSIMessage
    {
        public ConfigDataResponse()
        {
            Acds = new List<AcqData>();
            Tacds = new List<AcqData>();
        }

        [Ep2DataElement(TagName = "teld", TagPrefix = "")]
        public string Teld { get; set; }

        [Ep2DataElement(TagName = "acd", TagPrefix = "ep2")]
        public IList<AcqData> Acds { get; set; }

        [Ep2DataElement(TagName = "tacd", TagPrefix = "ep2")]
        public IList<AcqData> Tacds { get; set; }
    }
}