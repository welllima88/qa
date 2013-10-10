using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation
{
    public class AcquirerChange : WebObject

    {
        public static string Title
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content>h1")).Text; }
        }

        public static string Description
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content div>p")).Text; }
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
            get { return WebDriver.FindElement(By.CssSelector("td#content a[href$='/MassAcqExchange/StreamFile']")).Text; }
        }
    }
}