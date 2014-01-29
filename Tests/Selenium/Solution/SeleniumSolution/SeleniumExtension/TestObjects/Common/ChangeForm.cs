using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class ChangeForm : WebObject
    {
        public static string ChangeReason
        {
            set { WebDriver.FindAdaptedElement(By.Id("@??")).TextBox().TypeText(value); }
        }

        public static string ChangeRemark
        {
            set { WebDriver.FindAdaptedElement(By.Id("@??")).TextBox().TypeText(value); }
        }

        public static void ChangeTime(TimeSpan changeTime)
        {
            //TODO Actions here
            throw new NotImplementedException();
            //WebDriver.FindElement(By.CssSelector(CommonRes.Footer_Copyright));
        }
    }
}