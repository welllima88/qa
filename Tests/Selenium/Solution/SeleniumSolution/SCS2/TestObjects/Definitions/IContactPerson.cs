namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
{
    /// <summary>
    /// the contact person has adress and contact fields 
    /// </summary>
    public interface IContactPerson : IAdress, IContact
    {
        string FirstName { set; get; }
        string Name { set; get; }
        string Salutation { set; get; }
    }
}