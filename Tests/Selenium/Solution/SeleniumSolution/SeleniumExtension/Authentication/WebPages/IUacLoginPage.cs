using OpenQA.Selenium;

namespace Six.Scs.Tests.Selenium.Extension.Authentication.WebPages
{
    public interface IUacLoginPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElement LoginButton { get; }
    }
}