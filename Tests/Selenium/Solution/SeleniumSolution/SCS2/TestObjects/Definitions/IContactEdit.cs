namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface IContactEdit
    {
        string FirstName { set; get; }
        string Name { set; get; }
        string Salutation { set; get; }
        string Country { set; get; }
        string Language { set; get; }
        string Telephone { set; get; }
        string Mobile { set; get; }
        string Fax { set; get; }
        string Email { set; get; }
        string Street { set; get; }
        string Po { set; get; }
        string Zip { set; get; }
        string City { set; get; }
        string Region { set; get; }
        string CreateDate { get; }
        string Addition { set; get; }
    }
}