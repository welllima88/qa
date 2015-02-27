using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Hardware
{
    public class Management : WebObject
    {
        public static ButtonElement CheckButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("check")).Button(); }
        }

        public static TextFieldElement SerialNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("serialNumber")).TextField(); }
        }
    }
}