using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.TaskScheduler
{
    public class Create : WebObject
    {
        public static string MachineName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Machine")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Machine")).TextField().TypeText(value); }
        }

        public static string TaskName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_DisplayName")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_DisplayName")).TextField().TypeText(value); }
        }

        public static string Type
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Type")).Selector().SelectedOption; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Type")).Selector().SelectByText(value); }
        }

        public static string Module
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Name")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Name")).TextField().TypeText(value); }
        }

        public static string Arguments
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Args")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Args")).TextField().TypeText(value); }
        }

        public static string WorkingDirectory
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_WorkingDirectory")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_WorkingDirectory")).TextField().TypeText(value); }
        }

        public static string NextRun
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_NextRun")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_NextRun")).TextField().TypeText(value); }
        }

        public static string Interval
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Interval")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_Interval")).TextField().TypeText(value); }
        }

        public static string RetryInterval
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_RetryInterval")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_RetryInterval")).TextField().TypeText(value); }
        }

        public static string MaxRetries
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_MaxRetries")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_MaxRetries")).TextField().TypeText(value); }
        }

        public static string WaitOnShutdown
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TaskScheduler_WaitOnShutdown")).Text; }
            set { WebDriver.FindAdaptedElement(By.Id("TaskScheduler_WaitOnShutdown")).TextField().TypeText(value); }
        }

        public static IWebElementAdapter CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("create")); }
        }
    }
}