namespace Six.Scs.QA.TestData.ValueObjects
{
    public class Service
    {
        public string Name;
        public string Permission;

        public override bool Equals(object obj)
        {
            var other = obj as Service;
            if (other == null)
            {
                return false;
            }
            return Name == other.Name && Permission == other.Permission;
        }
    }
}