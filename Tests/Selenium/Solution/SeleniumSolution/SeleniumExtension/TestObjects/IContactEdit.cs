using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface IContactEdit
    {
        string FirstName { set; }
        string Name { set; }
        string Salutation { set; }
        string Country { set; }
        string Language { set; }
        string Telephone { set; }
        string Mobile { set; }
        string Fax { set; }
        string Email { set; }
        string Street { set; }
        string Po { set; }
        string Zip { set; }
        string City { set; }
        string Region { set; }
        string CreateDate { get; }
        string Addition { set; }
        IWebElement ClickAdressFromLocation { get; }
    }
}