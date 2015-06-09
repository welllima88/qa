using System.Collections.Generic;
using Six.Scs.Ep2.SI.Config.Messages.Containers;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgIn
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