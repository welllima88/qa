namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface IContact : IAdress
    {
        string FirstName { set; get; }
        string Name { set; get; }
        string Salutation { set; get; }
        string Language { set; get; }
        string Telephone { set; get; }
        string Mobile { set; get; }
        string Fax { set; get; }
        string Email { set; get; }
        string CreateDate { get; }
    }
}