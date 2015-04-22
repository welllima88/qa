using System;
using Six.QA.Selenium.Extension.Helper;
using Six.Scs.QA.Selenium.Administration.TaskScheduler;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow.Builder
{
    public class Tasks : IBuilder
    {
        public readonly Task Task;

        public Tasks(Task task)
        {
            Task = task;
        }

        public void Create()
        {
            List.CreateTask.Click();

            Selenium.Administration.TaskScheduler.Create.TaskName = Task.TaskName;
            Selenium.Administration.TaskScheduler.Create.MachineName = Task.MachineName;
            Selenium.Administration.TaskScheduler.Create.Type = "Executable";
            Selenium.Administration.TaskScheduler.Create.Module = "Module";
            Selenium.Administration.TaskScheduler.Create.Arguments = "Arguments /-aa ? :XX01";
            Selenium.Administration.TaskScheduler.Create.WorkingDirectory = @"c:\create\\Task_SYR\HOME";
            // Selenium.Administration.TaskScheduler.Create.NextRun = "";
            Selenium.Administration.TaskScheduler.Create.Interval = "1";
            Selenium.Administration.TaskScheduler.Create.RetryInterval = "2";
            Selenium.Administration.TaskScheduler.Create.MaxRetries = "11";
            Selenium.Administration.TaskScheduler.Create.WaitOnShutdown = "22";

            Selenium.Administration.TaskScheduler.Create.CreateButton.Click();
        }

        public void Edit()
        {
            SelectTask(Task);

            Selenium.Administration.TaskScheduler.Create.TaskName = "";
            Selenium.Administration.TaskScheduler.Create.MachineName = "";
            Selenium.Administration.TaskScheduler.Create.Type = "Executable";
            Selenium.Administration.TaskScheduler.Create.Module = "Module";
            Selenium.Administration.TaskScheduler.Create.Arguments = "Arguments /-aa ? :XX01";
            Selenium.Administration.TaskScheduler.Create.WorkingDirectory = @"c:\create\\Task_SYR\HOME";
            // Selenium.Administration.TaskScheduler.Create.NextRun = "";
            Selenium.Administration.TaskScheduler.Create.Interval = "1";
            Selenium.Administration.TaskScheduler.Create.RetryInterval = "2";
            Selenium.Administration.TaskScheduler.Create.MaxRetries = "11";
            Selenium.Administration.TaskScheduler.Create.WaitOnShutdown = "22";
        }

        public void Check()
        {
            throw new NotImplementedException();
        }

        private void SelectTask(object task)
        {
            throw new NotImplementedException();
        }
    }
}