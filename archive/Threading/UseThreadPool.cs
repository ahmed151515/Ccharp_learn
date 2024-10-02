

namespace archive.Threading
{
	public class UseThreadPool
	{
		// it is Background you must sure you have foreground work if you not have the program is terminated
		public static void Main()
		{
			// way 1 ThreadPool
			ThreadPool.QueueUserWorkItem(Print);
			// way 2 task
			Task.Run(Print);
			Console.ReadKey();

		}

		private static void Print()
		{
			PrintThreadData();
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(1000);
				Console.WriteLine(i);
			}
		}

		private static void Print(object? state) => Print();
		private static void PrintThreadData()
		{
			Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId} "
				+ $"Thread Name: {Thread.CurrentThread.Name} "
				+ $"Processor Id: {Thread.GetCurrentProcessorId()} "
				+ $"Is Background: {Thread.CurrentThread.IsBackground} "
				);
		}
	}
}
