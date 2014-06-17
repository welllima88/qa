using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu
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