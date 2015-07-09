﻿using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Administration.TaskScheduler
{
    public class List : WebObject
    {
        private const string Pre =
            "html body#body table#tableStructure tbody tr#rowContent td#content div table tbody tr";

        public static IWebElement CreateTask
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#content div a[href*='/TaskScheduler/Create']"));
            }
        }

        public static string TaskName
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(1)")).Text; }
        }

        public static string LastRun
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(2)")).Text; }
        }

        public static string LastStop
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(3)")).Text; }
        }

        public static string Duration
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(4)")).Text; }
        }

        public static string NextRun
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(5)")).Text; }
        }

        public static string Interval
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(6)")).Text; }
        }

        public static string ErrorCount
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(7)")).Text; }
        }

        public static string IsRunning
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(8)")).Text; }
        }

        public static string StartStopToggle
        {
            // /TaskScheduler/StopTask?taskId=
            // /TaskScheduler/StartTask?taskId=
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Pre + ":nth-child(9)")).Text; }
        }

        public static void Select(string taskName)
        {
            WebDriver.FindAdaptedElements(
                By.CssSelector("a[href*='/TaskScheduler/TaskSchedulerAdministration/Edit?TaskId=']"))
                .FirstOrDefault(e => e.Text.Equals(taskName))
                .Click();
        }
    }
}