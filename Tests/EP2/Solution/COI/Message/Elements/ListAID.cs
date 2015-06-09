using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message.Elements
{
    public class ListAID : IConfigDataObject
    {
        [Ep2DataElement(TagName = "AID")]
        public IEnumerable<string> ListAIds { get; set; }
    }
}