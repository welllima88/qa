using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Webpages
{
    public interface IUacLogOnPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        IWebElementAdapter LoginButton { get; }
    }
}