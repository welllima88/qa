using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Administration.SerialNumberManage
{
    public class Import : WebObject
    {
        public static string Supplier
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ManufacturerId")).Selector().SelectedOption; }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#ManufacturerId")).Selector().SelectByText(value); }
        }

        public static string StartField
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#StartIndex")).TextField().Text(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#StartIndex")).TextField().TypeText(value); }
        }

        public static string LengthField
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Length")).TextField().Text(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Length")).TextField().TypeText(value); }
        }

        public static string SerialNumbersField
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("textarea#SerialNumbersValues")).TextArea().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("textarea#SerialNumbersValues")).TextArea().TypeText(value);
            }
        }

        public static ButtonElement ImportButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#import")).Button(); }
        }

        public static string Preview
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#Preview")).Text; }
        }
    }
}