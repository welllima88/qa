using Six.Scs.Ep2.Coi.Message.Elements;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message
{
    [Ep2Message(Ep2MessageNames.ConfigDataNotification)]
    [Ep2Version("0600")]
    public class ConfigDataNotification : BaseMessage
    {
        public ConfigDataNotification()
        {
            Ad = new Ad();
            Tcd = new Tcd();
        }

        [Ep2DataElement(TagName = "tcd")]
        public Tcd Tcd { get; set; }

        [Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string AcqId { get; set; }

        [Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string ScId { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.n)]
        public DataProcessingCommand DataProcCmd { get; set; }

        [Ep2DataElement(TagName = "ad")]
        public Ad Ad { get; set; }
    }
}