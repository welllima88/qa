namespace Six.Scs.Test.Model.ValueObjects
{
    /// <summary>
    ///     the contact person has adress and contact fields
    /// </summary>
    public class Person
    {
        public Adress Adress { get; set; }
        public Contact Contact { get; set; }
        public string FirstName { set; get; }
        public string Name { set; get; }
        public string Salutation { set; get; }
        public string Id { get; set; }
    }
}