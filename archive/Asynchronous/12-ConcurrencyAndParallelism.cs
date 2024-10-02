using System.Diagnostics;

namespace archive.Asynchronous
{
	public class ConcurrencyAndParallelism
	{
		public static async Task Main()
		{
			var tasks = new List<DailyDuty>();

			for (int i = 1; i <= 10; i++)
			{
				tasks.Add(new DailyDuty($"Task {i}"));
			}
			var stopwatch = new Stopwatch();

			stopwatch.Start();

			Console.WriteLine("\n\t\tUsing Parallel Processing");
			await ProcessTasksInParallel(tasks);

			stopwatch.Stop();

			var parallelTime = stopwatch.Elapsed;

			stopwatch.Start();

			stopwatch.Restart();

			Console.WriteLine("\n\t\tUsing Concuurent Processing");
			await ProcessTasksInConcuurent(tasks);

			stopwatch.Stop();

			var concuurentTime = stopwatch.Elapsed;


			Console.WriteLine($"Parallel Time: {parallelTime}");
			Console.WriteLine($"Coucrrent Time: {concuurentTime}");


		}

		static Task ProcessTasksInParallel(IEnumerable<DailyDuty> tasks)
		{
			Parallel.ForEach(tasks, (duty) => duty.Process());
			return Task.CompletedTask;
		}
		static Task ProcessTasksInConcuurent(IEnumerable<DailyDuty> tasks)
		{
			foreach (var task in tasks)
			{
				task.Process();
			}
			return Task.CompletedTask;
		}
	}

	class DailyDuty
	{
		static readonly Random random = new Random();
		private readonly int time;
		public string Title { get; private set; }
		public bool IsProcessed { get; private set; }

		public DailyDuty(string title)
		{
			Title = title;
			time = random.Next(500, 2500);
		}
		public void Process()
		{
			ShowThreadInfo();
			Task.Delay(time).Wait();
			IsProcessed = true;
		}
		public static void ShowThreadInfo(Thread? Th = null)
		{
			if (Th is null)
			{
				Th = Thread.CurrentThread;
			}
			Console.WriteLine($"Thread Info: ID = {Th.ManagedThreadId}," +
				$" Pooled = {Th.IsThreadPoolThread}, Background = {Th.IsBackground}" +
				$" Processor ID: {Thread.GetCurrentProcessorId()}");
		}
	}
}
