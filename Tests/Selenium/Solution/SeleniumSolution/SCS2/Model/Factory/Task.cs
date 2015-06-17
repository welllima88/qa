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
                Module = "Module",
                RetryInterval = "2",
                TaskName = "Task SYR Auto A",
                Type = "Executable",
                WaitOnShutdown = "22",
                WorkingDirectory = @"c:\create\\Task_SYR\HOME"
            };
        }
    }
}