namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions
{
    /// <summary>
    ///     the contact person has adress and contact fields
    /// </summary>
    public class ContactPersonData
    {
        public AdressData Adress { get; set; }
        public ContactData Contact { get; set; }
        public string FirstName { set; get; }
        public string Name { set; get; }
        public string Salutation { set; get; }
    }
}