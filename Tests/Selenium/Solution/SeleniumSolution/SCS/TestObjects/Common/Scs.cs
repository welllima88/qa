using SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Menu;
using SIX.SCS.QA.Selenium.Extension.Authentication;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Common
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