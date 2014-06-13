using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu
{
    public abstract class MenuObject : WebObject
    {
        protected MenuObject()
        {
            // "//td[@id='leftHandMenu']/span[@id=\"ctl00_trvNavigation\"]/descendant::";
            Prefix = MenuRes.Prefix;
        }
    }
}