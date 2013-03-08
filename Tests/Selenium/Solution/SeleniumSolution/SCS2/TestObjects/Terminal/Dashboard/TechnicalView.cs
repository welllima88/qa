using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TechnicalView : PortletViewBase
    {
        //baseUrl + "TerminalTechnicalViewpointPortlet?TerminalId=21011402" + "&DontCacheRequest=cbc996ae-865f-b7cd-358a-2c0e769f53dc"

        public TechnicalView(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div#portlet_TerminalTechnicalViewpointPortlet_content div#SetupDataTree ul";
        }

        public IWebElement TerminalId
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(1)" + Suf));
            }
        }

        public IWebElement SerialNo
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(3)" + Suf));
            }
        }

        public IWebElement Password
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(4)" + Suf));
            }
        }

        public IWebElement TerminalType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(5)" + Suf));
            }
        }

        public IWebElement NetType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + "li:nth-child(6)" + Suf));
            }
        }
    }
}