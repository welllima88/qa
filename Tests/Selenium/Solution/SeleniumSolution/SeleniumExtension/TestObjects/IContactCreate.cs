using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface IContactCreate
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
        string AddressAddition { set; }
        IWebElement SaveButton { get; }                
    }
}