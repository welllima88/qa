using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.Coi.Message.Elements
{
    public class Aisd
    {
        protected bool Equals(Aisd other)
        {
            return AcqID == other.AcqID && string.Equals(AcqInitPubKey, other.AcqInitPubKey);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (AcqID.GetHashCode()*397) ^ (AcqInitPubKey != null ? AcqInitPubKey.GetHashCode() : 0);
            }
        }

        [Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public long AcqID { get; set; }

        [Ep2DataElement(TagName = "AcqInitPubKey")]
        public string AcqInitPubKey { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Aisd) obj);
        }
    }
}