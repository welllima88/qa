using System.Collections.Generic;

namespace SIX.SCS.QA.Tests.EP2.Message.Laid
{
    public class Response
    {
        public IList<string> ListAid { get; set; }
        public string ScId { get; set; }
        public int AcqId { get; set; }
    }
}