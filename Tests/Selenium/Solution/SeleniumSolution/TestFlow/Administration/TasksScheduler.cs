using System;
using NUnit.Framework;
using Six.Scs.Test.Model;
using List = Six.Scs.Test.UI.Administration.TaskScheduler.List;

namespace Six.Scs.Test.Administration
{
    public static class TasksScheduler
    {
        public static void Delete(Task task)
        {
            Open(task);
            Workflow.TasksScheduler.Delete();

            Assert.Throws(typeof (NullReferenceException), () => List.Open(task.TaskName));
        }

        public static Task Edit(Task task)
        {
            var t = Factory.Task.Edit();
            Open(task);
            Workflow.TasksScheduler.Edit(t);
            Open(t);
            Check(t);
            return t;
        }

        public static Task Create()
        {
            var task = Factory.Task.Create();
            Workflow.TasksScheduler.Create(task);
            Open(task);
            Check(task);
            return task;
        }

        private static void Open(Task task)
        {
            List.Open(task.TaskName);
        }

        public static void Check(Task task)
        {
            Assert.That(UI.Administration.TaskScheduler.Create.TaskName, Is.EqualTo(task.TaskName));
            Assert.That(UI.Administration.TaskScheduler.Create.MachineName, Is.EqualTo(task.MachineName));
            Assert.That(UI.Administration.TaskScheduler.Create.Type, Is.EqualTo(task.Type));
            Assert.That(UI.Administration.TaskScheduler.Create.Module, Is.EqualTo(task.Module));
            Assert.That(UI.Administration.TaskScheduler.Create.Arguments, Is.EqualTo(task.Arguments));
            Assert.That(UI.Administration.TaskScheduler.Create.WorkingDirectory, Is.EqualTo(task.WorkingDirectory));
            //Assert.That(View.Administration.TaskScheduler.Create.NextRun, Is.EqualTo(task.NextRun));
            Assert.That(UI.Administration.TaskScheduler.Create.Interval, Is.EqualTo(task.Interval));
            Assert.That(UI.Administration.TaskScheduler.Create.RetryInterval, Is.EqualTo(task.RetryInterval));
            Assert.That(UI.Administration.TaskScheduler.Create.MaxRetries, Is.EqualTo(task.MaxRetries));
            Assert.That(UI.Administration.TaskScheduler.Create.WaitOnShutdown, Is.EqualTo(task.WaitOnShutdown));
            UI.Administration.TaskScheduler.Create.CancelButton.Click(); //leave edit mode -> list
        }
    }
}