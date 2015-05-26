using System.Collections.Generic;

namespace SIX.SCS.QA.Tests.EP2.Data
{
    public class MessageObject
    {
        public string ConfDataObj { get; set; }
        public string ScId { get; set; }
        public int AcqId { get; set; }
        public IList<string> ListOfAid { get; set; }
    }
}