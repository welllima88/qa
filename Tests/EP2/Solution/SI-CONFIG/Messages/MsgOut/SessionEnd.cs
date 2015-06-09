using System;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.MsgOut
{
    [Ep2Version("0520")]
    [Ep2Message(Ep2MessageNames.SessionEnd)]
    public class SessionEnd : BaseMessage, IamSIMessage
    {
        public SessionEnd()
        {
            LocDate = DateTime.Now;
            LocTime = DateTime.Now;
        }

        [Ep2DataElement(DataType = Ep2DataType.date)]
        public DateTime LocDate { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.time)]
        public DateTime LocTime { get; set; }

        [Ep2DataElement(TagPrefix = "")] //something in minutes
        public int? TrigSWDL { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.n)]
        public long SCID { get; set; }

        [Ep2DataElement(DataType = Ep2DataType.n)]
        public string TrmID { get; set; }
    }
}