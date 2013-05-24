using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface ILocationCreate
    {
        string Country { set; get; }
        string Zip { set; }
        string City { set; }
        string AdressAddition { set; }
        string Po { set; }
        string Region { set; }
        string Telephone { set; }
        string Mobile { set; }
        string Fax { set; }
        string Email { set; }
        string SapNumber { set; }
        string CompanyName { set; }
        string StreetName { set; }
        string Language { set; get; }
        string Web { set; }
        IWebElement SaveButton { get; }
    }
}