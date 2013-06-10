using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public abstract class MenuObject : WebObject
    {
        protected MenuObject(IWebDriverAdapter driver) : base(driver)
        {
            // "//td[@id='leftHandMenu']/span[@id=\"ctl00_trvNavigation\"]/descendant::";
            Prefix = Menu.Prefix;
        }
    }
}