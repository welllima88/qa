namespace Six.Scs.Test.Model
{
    public class Service
    {
        public string Name;
        public string Permission;

        public bool Equals(Service other)
        {
            return string.Equals(Name, other.Name) && string.Equals(Permission, other.Permission);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0)*397) ^
                       (Permission != null ? Permission.GetHashCode() : 0);
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Service)) return false;
            return Equals((Service) obj);
        }
    }
}