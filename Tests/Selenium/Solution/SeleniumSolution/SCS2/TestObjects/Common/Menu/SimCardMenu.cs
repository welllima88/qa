using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class SimCardMenu : MenuObject
    {
        public SimCardMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement SimCardManagement
        {
            get { return Driver.FindElement(By.CssSelector(Menu.SimCardMenu_SimCardManagement)); }
        }
    }
}