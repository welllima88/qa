using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.Authentication.WebPages
{
    public interface IUacLoginPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElement LoginButton { get; }
    }
}