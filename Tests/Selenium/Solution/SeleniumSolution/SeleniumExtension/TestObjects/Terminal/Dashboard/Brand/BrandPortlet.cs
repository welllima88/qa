using OpenQA.Selenium;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand
{
    public class BrandPortlet : PortletViewBase
    {
        public static IWebElement NewBrandButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_BrandPortlet div.portletLinks a[href*='/CreateContract/ListByTerminal?TerminalId=']"));
            }
        }

        public static IWebElement Brand(string brandId)
        {
            return
                WebDriver.FindAdaptedElement(
                    By.CssSelector(string.Format(
                        "div#frame_BrandPortlet div#contractTree ul li[id='brandContract_{0}']", brandId)));
        }
    }
}