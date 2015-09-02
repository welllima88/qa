using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Administration.TaskScheduler;

namespace Six.Scs.Test.Workflow
{
    public class TasksScheduler
    {
        public static void Create(Task task)
        {
            List.CreateTask.Click();

            UI.Administration.TaskScheduler.Create.TaskName = task.TaskName;
            UI.Administration.TaskScheduler.Create.MachineName = task.MachineName;
            UI.Administration.TaskScheduler.Create.Type = task.Type;
            UI.Administration.TaskScheduler.Create.Module = task.Module;
            UI.Administration.TaskScheduler.Create.Arguments = task.Arguments;
            UI.Administration.TaskScheduler.Create.WorkingDirectory = task.WorkingDirectory;
            // View.Administration.TaskScheduler.Create.NextRun = task.NextRun;
            UI.Administration.TaskScheduler.Create.Interval = task.Interval;
            UI.Administration.TaskScheduler.Create.RetryInterval = task.RetryInterval;
            UI.Administration.TaskScheduler.Create.MaxRetries = task.MaxRetries;
            UI.Administration.TaskScheduler.Create.WaitOnShutdown = task.WaitOnShutdown;

            UI.Administration.TaskScheduler.Create.CreateButton.Click();
        }

        public static void Edit(Task task)
        {
            UI.Administration.TaskScheduler.Create.TaskName = task.TaskName;
            UI.Administration.TaskScheduler.Create.MachineName = task.MachineName;
            UI.Administration.TaskScheduler.Create.Type = task.Type;
            UI.Administration.TaskScheduler.Create.Module = task.Module;
            UI.Administration.TaskScheduler.Create.Arguments = task.Arguments;
            UI.Administration.TaskScheduler.Create.WorkingDirectory = task.WorkingDirectory;
            // View.Administration.TaskScheduler.Create.NextRun = task.NextRun;
            UI.Administration.TaskScheduler.Create.Interval = task.Interval;
            UI.Administration.TaskScheduler.Create.RetryInterval = task.RetryInterval;
            UI.Administration.TaskScheduler.Create.MaxRetries = task.MaxRetries;
            UI.Administration.TaskScheduler.Create.WaitOnShutdown = task.WaitOnShutdown;

            UI.Administration.TaskScheduler.Create.SaveButton.Click();
        }

        public static void Delete()
        {
            UI.Administration.TaskScheduler.Edit.DeleteButton.Click();
            UI.Administration.TaskScheduler.Edit.DeleteConfirmButton.Click();
        }
    }
}