using Six.Scs.Tests.Selenium.Extension.Authentication;
using Six.Scs.Tests.Selenium.TestObjects.Menu;

namespace Six.Scs.Tests.Selenium.TestObjects.Common
{
    public class Scs : IApplication
    {
        private readonly HeadMenu _headMenu;

        public Scs()
        {
            _headMenu = new HeadMenu();
        }

        public void Logout()
        {
            _headMenu.Logout.Click();
        }
    }
}