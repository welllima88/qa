using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class ChangeForm : WebObject
    {
        public static string Reason
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[id$='_NotificationReason']"))
                    .Selector()
                    .SelectByValue(value);
            }
        }

        public static string Remark
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input[id$='_NotificationRemarks']"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static void DelayTime(TimeSpan changeTime)
        {
            if (changeTime.CompareTo(new TimeSpan()) > 0)
            {
                WebDriver.FindAdaptedElement(By.Id("ChangeNow")).CheckBox().Set(false);
                // Example for setting a time value: 01.02.2014 13:30:41
                WebDriver.FindAdaptedElement(By.Id("ChangeOn"))
                    .TextBox()
                    .TypeText(changeTime.ToString(""));
            }
        }
    }
}