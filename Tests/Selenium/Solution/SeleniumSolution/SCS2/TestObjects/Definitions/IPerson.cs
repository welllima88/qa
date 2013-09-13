namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
{
    public interface IPerson : IAdress, IContact
    {
        string FirstName { set; get; }
        string Name { set; get; }
        string Salutation { set; get; }
    }
}