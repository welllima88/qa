using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Terminal
{
    public class ContactlessCapability : WebObject
    {
        public static string ContactLessOptionTerminal
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("SelectedContactLessOption"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.Id("SelectedContactLessOption"))
                    .Selector()
                    .SelectedOption;
            }
        }

        public static IEnumerable<string> GetContactLessOptionForBrands
        {
            get
            {
                return WebDriver.FindAdaptedElements(By.CssSelector("select[id*='ContactlessBrandsSorted']"))
                    .Select(e => e.Selector().SelectedOption);
            }
        }

        public static void Save()
        {
            WebDriver.FindAdaptedElement(By.Id("#save")).Click();
        }
    }
}