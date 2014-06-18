using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.Authentication.WebPages
{
    public interface IUacLogOnPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElement LoginButton { get; }
    }
}