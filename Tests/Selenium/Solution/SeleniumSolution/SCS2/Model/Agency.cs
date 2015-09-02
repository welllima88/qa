namespace Six.Scs.Test.Model
{
    public class Agency
    {
        public Adress Adress { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Supplier { get; set; }
        public Contact Contact { get; set; }
        public string SbsAgentId { get; set; }
        public bool Status { get; set; }
    }
}