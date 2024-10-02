using System.Diagnostics;

namespace archive.Asynchronous
{
	public class LongRunningTask
	{
		public static void Main()
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var task = Task.Factory.StartNew(RunLongTask, TaskCreationOptions.LongRunning);
			stopWatch.Stop();
			Console.WriteLine("start: " + stopWatch.Elapsed);
			task.Wait();
		}

		static void RunLongTask()
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			Thread.Sleep(10000);
			ThreadVsTasks.ShowThreadInfo();
			stopWatch.Stop();
			Console.WriteLine("Done");
			Console.WriteLine("Execution: " + stopWatch.Elapsed);

		}
	}
}
