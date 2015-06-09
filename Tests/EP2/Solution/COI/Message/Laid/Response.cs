using System.Collections.Generic;

namespace Six.Scs.Ep2.Coi.Message.Laid
{
    public class Response
    {
        public IList<string> ListAid { get; set; }
        public string ScId { get; set; }
        public int AcqId { get; set; }
    }
}