using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Administration.TaskScheduler;

namespace Six.Scs.Test.Workflow
{
    public class TasksScheduler
    {
        public static void Create(Task task)
        {
            List.CreateTask.Click();

            View.Administration.TaskScheduler.Create.TaskName = task.TaskName;
            View.Administration.TaskScheduler.Create.MachineName = task.MachineName;
            View.Administration.TaskScheduler.Create.Type = task.Type;
            View.Administration.TaskScheduler.Create.Module = task.Module;
            View.Administration.TaskScheduler.Create.Arguments = task.Arguments;
            View.Administration.TaskScheduler.Create.WorkingDirectory = task.WorkingDirectory;
            // View.Administration.TaskScheduler.Create.NextRun = task.NextRun;
            View.Administration.TaskScheduler.Create.Interval = task.Interval;
            View.Administration.TaskScheduler.Create.RetryInterval = task.RetryInterval;
            View.Administration.TaskScheduler.Create.MaxRetries = task.MaxRetries;
            View.Administration.TaskScheduler.Create.WaitOnShutdown = task.WaitOnShutdown;

            View.Administration.TaskScheduler.Create.CreateButton.Click();
        }

        public static void Edit(Task task)
        {
            View.Administration.TaskScheduler.Create.TaskName = task.TaskName;
            View.Administration.TaskScheduler.Create.MachineName = task.MachineName;
            View.Administration.TaskScheduler.Create.Type = task.Type;
            View.Administration.TaskScheduler.Create.Module = task.Module;
            View.Administration.TaskScheduler.Create.Arguments = task.Arguments;
            View.Administration.TaskScheduler.Create.WorkingDirectory = task.WorkingDirectory;
            // View.Administration.TaskScheduler.Create.NextRun = task.NextRun;
            View.Administration.TaskScheduler.Create.Interval = task.Interval;
            View.Administration.TaskScheduler.Create.RetryInterval = task.RetryInterval;
            View.Administration.TaskScheduler.Create.MaxRetries = task.MaxRetries;
            View.Administration.TaskScheduler.Create.WaitOnShutdown = task.WaitOnShutdown;

            View.Administration.TaskScheduler.Create.CreateButton.Click();
        }

        public static void Delete()
        {
            View.Administration.TaskScheduler.Edit.DeleteButton.Click();
            View.Administration.TaskScheduler.Edit.DeleteConfirmButton.Click();
        }
    }
}