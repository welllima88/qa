namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
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