using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.WebPages
{
    public interface IUacLoginPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElement LoginButton { get; }
    }
}