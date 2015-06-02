using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.SCS.QA.Tests.EP2.Message.Basic;

namespace SIX.SCS.QA.Tests.EP2.Message.Elements
{
    public class ListAID : IConfigDataObject
    {
        [Ep2DataElement(TagName = "AID")]
        public IEnumerable<string> LAID { get; set; }
    }
}