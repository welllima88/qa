using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.TaskScheduler
{
    public class Edit : WebObject
    {
        private const string Pre =
            "html body#body table#tableStructure tbody tr#rowContent td#content table tbody tr.Summary td";

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}