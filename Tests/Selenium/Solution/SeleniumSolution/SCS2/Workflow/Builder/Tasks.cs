using System;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Administration.TaskScheduler;

namespace Six.Scs.Test.Workflow.Builder
{
    public class Tasks : Helper.Builder
    {
        public readonly Task Task;

        public override void Create()
        {
            List.CreateTask.Click();

            View.Administration.TaskScheduler.Create.TaskName = Task.TaskName;
            View.Administration.TaskScheduler.Create.MachineName = Task.MachineName;
            View.Administration.TaskScheduler.Create.Type = "Executable";
            View.Administration.TaskScheduler.Create.Module = "Module";
            View.Administration.TaskScheduler.Create.Arguments = "Arguments /-aa ? :XX01";
            View.Administration.TaskScheduler.Create.WorkingDirectory = @"c:\create\\Task_SYR\HOME";
            View.Administration.TaskScheduler.Create.NextRun = "";
            View.Administration.TaskScheduler.Create.Interval = "1";
            View.Administration.TaskScheduler.Create.RetryInterval = "2";
            View.Administration.TaskScheduler.Create.MaxRetries = "11";
            View.Administration.TaskScheduler.Create.WaitOnShutdown = "22";
            
            View.Administration.TaskScheduler.Create.CreateButton.Click();
        }

        public override void Edit()
        {
            SelectTask(Task);

            View.Administration.TaskScheduler.Create.TaskName = "";
            View.Administration.TaskScheduler.Create.MachineName = "";
            View.Administration.TaskScheduler.Create.Type = "Executable";
            View.Administration.TaskScheduler.Create.Module = "Module";
            View.Administration.TaskScheduler.Create.Arguments = "Arguments /-aa ? :XX01";
            View.Administration.TaskScheduler.Create.WorkingDirectory = @"c:\create\\Task_SYR\HOME";
            View.Administration.TaskScheduler.Create.NextRun = "";
            View.Administration.TaskScheduler.Create.Interval = "1";
            View.Administration.TaskScheduler.Create.RetryInterval = "2";
            View.Administration.TaskScheduler.Create.MaxRetries = "11";
            View.Administration.TaskScheduler.Create.WaitOnShutdown = "22";
        }

        public override void Check()
        {
            throw new NotImplementedException();
        }

        private void SelectTask(object task)
        {
            throw new NotImplementedException();
        }
    }
}