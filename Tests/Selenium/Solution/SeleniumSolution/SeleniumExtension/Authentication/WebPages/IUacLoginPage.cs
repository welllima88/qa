using OpenQA.Selenium;

namespace SIX.SCS.Tests.Selenium.Extension.Authentication.WebPages
{
    public interface IUacLoginPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElement LoginButton { get; }
    }
}