using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Massmuation
{
    public class AcquirerChange : WebObject

    {
        public static string Title
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content>h1")).Text; }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div>p")).Text; }
        }

        public static IWebElementAdapter FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content input[name='filehandle']")); }
        }

        public static IWebElementAdapter FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#upload")); }
        }

        public static string DownloadTemplate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#content a[href$='/MassAcqExchange/StreamFile']"))
                        .Text;
            }
        }
    }
}