using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class ChangeForm : WebObject
    {
        public static string Reason
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[id$='_NotificationReason']"))
                    .Selector()
                    .SelectByText(value);
            }
        }

        public static string Remark
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input[id$='_NotificationRemarks']"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static void DelayTime(TimeSpan changeTime)
        {
            if (changeTime.CompareTo(new TimeSpan()) > 0)
            {
                WebDriver.FindAdaptedElement(By.Id("ChangeInFuture")).CheckBox().Set(false);
                // Example for setting a time value: 01.02.2014 13:30:41
                WebDriver.FindAdaptedElement(By.Id("ChangeOn"))
                    .TextField()
                    .TypeText(changeTime.ToString("dd'.'MM'.'yyyy HH':'mm"));
            }
        }
    }
}