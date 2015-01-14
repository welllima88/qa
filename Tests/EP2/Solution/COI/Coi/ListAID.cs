using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Coi
{
    [Ep2DataElement(TagName = "LAID", TagPrefix = "ep2")]
    public class ListAID
    {
        public ListAID()
        {
            AID = new List<byte[]>();
        }

        [Ep2DataElement(TagName = "AID", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false)]
        public IList<byte[]> AID { get; set; }
    }
}