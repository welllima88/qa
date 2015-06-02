using System.Collections.Generic;

namespace SIX.SCS.QA.Tests.EP2.Message.ConfigDataObjects
{
    public class Laid
    {
        public string ConfDataObj { get; set; }
        public string ScId { get; set; }
        public int AcqId { get; set; }
        public IList<string> ListOfAid { get; set; }
    }
}