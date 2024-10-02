
using System.Runtime.CompilerServices;

namespace archive.Asynchronous
{
	public class SyncVsAsync
	{
		public static void Main()
		{
			ShowThreadInfo();
			CallSync();
			ShowThreadInfo();
			CallAsync();
			ShowThreadInfo();


			Console.ReadKey();
		}

		static void CallSync()
		{
			Thread.Sleep(4000);
			ShowThreadInfo();
			Task.Run(() => Console.WriteLine("-------- Sync --------")).Wait();
		}
		static void CallAsync()
		{
			ShowThreadInfo();
			Task.Delay(4000).GetAwaiter().OnCompleted(() =>
			{
				ShowThreadInfo();
				Console.WriteLine("-------- Async --------");
			});
		}
		public static void ShowThreadInfo([CallerLineNumber] int line = 0, Thread Th = null)
		{
			if (Th is null)
			{
				Th = Thread.CurrentThread;
			}
			Console.WriteLine($"Line({line})  Thread Info: ID = {Th.ManagedThreadId}," +
				$" Pooled = {Th.IsThreadPoolThread}, Background = {Th.IsBackground}");
		}
	}
}
