namespace Six.Test.Selenium.Authentication.Webpages
{
    public interface IUacLogOnPage
    {
        string UserName { set; }
        string UserPasswort { set; }
        void Login();
    }
}