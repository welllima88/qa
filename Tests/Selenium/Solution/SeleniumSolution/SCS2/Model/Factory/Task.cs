namespace Six.Scs.Test.Model.Factory
{
    public class Task
    {
        public static ValueObjects.Task Create()
        {
            return new ValueObjects.Task
            {
                Arguments = "Arguments /-aa ? :XX01",
                Interval = "1",
                MachineName = "Machine SYR Auto A",
                MaxRetries = "11",
                Module = "Module A",
                RetryInterval = "2",
                TaskName = "Task SYR Auto A",
                Type = "Executable",
                WaitOnShutdown = "22",
                WorkingDirectory = @"c:\create\\Task_SYR\HOME"
            };
        }

        public static ValueObjects.Task Edit()
        {
            return new ValueObjects.Task
            {
                Arguments = "Arguments /-bb ? :XX01",
                Interval = "2",
                MachineName = "Machine SYR Auto B",
                MaxRetries = "22",
                Module = "Module B",
                RetryInterval = "4",
                TaskName = "Task SYR Auto B",
                Type = "IScheduledTask",
                WaitOnShutdown = "44",
                WorkingDirectory = @"c:\edit\\Task_SYR\HOME"
            };
        }
    }
}