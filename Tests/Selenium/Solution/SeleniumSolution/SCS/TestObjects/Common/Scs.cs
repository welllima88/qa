using SIX.SCS.Tests.Selenium.Extension.Authentication;
using SIX.SCS.Tests.Selenium.TestObjects.Menu;

namespace SIX.SCS.Tests.Selenium.TestObjects.Common
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