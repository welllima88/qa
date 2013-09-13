using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu
{
    public abstract class MenuObject : WebObject
    {
        protected MenuObject()
        {
            // "//td[@id='leftHandMenu']/span[@id=\"ctl00_trvNavigation\"]/descendant::";
            Prefix = Menu.Prefix;
        }
    }
}