using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Massmuation
{
    public class FileUpload : WebObject

    {
        public static string Title
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content>h1")).Text; }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content form>p")).Text; }
        }

        public static IWebElement FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content input[name='batchfile']")); }
        }

        public static IWebElement FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#upload")); }
        }

        public static string DownloadTemplate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#content form div a[href$='/Download']"))
                        .Text;
            }
        }
    }
}