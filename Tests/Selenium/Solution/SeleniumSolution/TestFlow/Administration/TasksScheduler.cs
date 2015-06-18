using System;
using NUnit.Framework;
using Six.Scs.Test.Model.ValueObjects;

namespace Six.Scs.Test.Administration
{
    public static class TasksScheduler
    {
        public static void Delete(Task task)
        {
            Workflow.TasksScheduler.Delete(task);
        }

        public static Task Edit()
        {
            var task = Model.Factory.Task.Edit();
            Workflow.TasksScheduler.Edit(task);
            Check(task);
            return task;
        }

        public static Task Create()
        {
            var task = Model.Factory.Task.Create();
            Workflow.TasksScheduler.Create(task);
            Check(task);
            return task;
        }

        public static void Check(Task task)
        {
            Assert.That(View.Administration.TaskScheduler.Create.TaskName, Is.EqualTo(task.TaskName));
            Assert.That(View.Administration.TaskScheduler.Create.MachineName, Is.EqualTo(task.MachineName));
            Assert.That(View.Administration.TaskScheduler.Create.Type, Is.EqualTo(task.Type));
            Assert.That(View.Administration.TaskScheduler.Create.Module, Is.EqualTo(task.Module));
            Assert.That(View.Administration.TaskScheduler.Create.Arguments, Is.EqualTo(task.Arguments));
            Assert.That(View.Administration.TaskScheduler.Create.WorkingDirectory, Is.EqualTo(task.WorkingDirectory));
            //Assert.That(View.Administration.TaskScheduler.Create.NextRun, Is.EqualTo(task.NextRun));
            Assert.That(View.Administration.TaskScheduler.Create.Interval, Is.EqualTo(task.Interval));
            Assert.That(View.Administration.TaskScheduler.Create.RetryInterval, Is.EqualTo(task.RetryInterval));
            Assert.That(View.Administration.TaskScheduler.Create.MaxRetries, Is.EqualTo(task.MaxRetries));
            Assert.That(View.Administration.TaskScheduler.Create.WaitOnShutdown, Is.EqualTo(task.WaitOnShutdown));
        }
    }
}