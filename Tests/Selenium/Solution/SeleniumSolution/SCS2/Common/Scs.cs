using Six.Scs.QA.Selenium.Extension.Authentication;

namespace Six.Scs.QA.Selenium.Common
{
    public class Scs : IApplication
    {
        private readonly HeadMenu _headMenu;

        public Scs()
        {
            _headMenu = new HeadMenu();
        }

        public void LogOff()
        {
            _headMenu.Logout.Click();
        }
    }
}