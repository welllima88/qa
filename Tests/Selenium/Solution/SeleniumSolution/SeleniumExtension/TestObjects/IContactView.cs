namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface IContactView
    {
        string FirstName { get; }
        string Name { get; }
        string Salutation { get; }
        string Country { get; }
        string Language { get; }
        string Telephone { get; }
        string Mobile { get; }
        string Fax { get; }
        string Email { get; }
        string Street { get; }
        string Po { get; }
        string Zip { get; }
        string City { get; }
        string Region { get; }
        string CreateDate { get; }
        string AddressAddition { get; }
    }
}