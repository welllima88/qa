using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Coi.Laid
{
    public class ListAID
    {
        public ListAID()
        {
            AID = new List<string>();
        }

        [Ep2DataElement]
        public IList<string> AID { get; set; }
    }
}