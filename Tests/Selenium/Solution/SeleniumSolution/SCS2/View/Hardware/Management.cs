using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Hardware
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