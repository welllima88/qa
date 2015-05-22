using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Message.Elements
{
    public class ListAID
    {
        [Ep2DataElement]
        public IList<string> AID { get; set; }
    }
}