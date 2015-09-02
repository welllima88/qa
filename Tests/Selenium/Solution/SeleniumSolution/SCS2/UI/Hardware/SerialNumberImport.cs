using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Hardware
{
    public class SerialNumberImport : WebObject
    {
        public static string Title
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#content>h1"))
                        .Text;
            }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content form>p")).Text; }
        }

        public static IWebElement FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content input[type='file']")); }
        }

        public static IWebElement FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("upload")); }
        }

        public static string DownloadTemplate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/HWManagement/ImportSerialNumber/StreamFile']"))
                        .Text;
            }
        }
    }
}