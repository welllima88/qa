using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public class AcqData
    {
        [Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2")]
        public string AcqID { get; set; }
    }
}