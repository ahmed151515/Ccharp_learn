using System.Runtime.CompilerServices;

namespace archive.Asynchronous
{
	public class AsyncFunctions
	{
		public static bool ended = false;
		public static async Task ArchiveMain()
		{
			const string url = "https://www.google.com";
			// way 1
			//var task = Task.Run(() => ReadContent(url));
			//var awaiter = task.GetAwaiter();
			//awaiter.OnCompleted(() =>
			//			{
			//				Console.WriteLine(awaiter.GetResult());
			//			});

			// async way
			//ShowThreadInfo();

			ended = await ReadContentAsync(url);
			//Console.WriteLine(content2);





			//ShowThreadInfo();

		}

		static Task<string> ReadContent(string url)
		{
			var http = new HttpClient();

			var task = http.GetStringAsync(url);
			return task;
		}
		static async Task<bool> ReadContentAsync(string url)
		{
			//ShowThreadInfo();
			var http = new HttpClient();

			var task = http.GetStringAsync(url);



			//ShowThreadInfo();
			var content = await task;
			//ShowThreadInfo();/

			return task.IsCompleted;
		}
		public static void ShowThreadInfo([CallerLineNumber] int line = 0, Thread Th = null
			, [CallerMemberName] string member = "")
		{
			if (Th is null)
			{
				Th = Thread.CurrentThread;
			}
			Console.WriteLine($"Member({member}), Line({line})  Thread Info: ID = {Th.ManagedThreadId}," +
				$" Pooled = {Th.IsThreadPoolThread}, Background = {Th.IsBackground}");
		}
		static async Task<int> Task5s()
		{
			ShowThreadInfo();
			await Task.Delay(5000);
			ShowThreadInfo();
			Console.WriteLine($"task5s end at {DateTime.Now}");
			return 1;
		}
		static async Task<int> Task10s()
		{
			ShowThreadInfo();
			await Task.Delay(10000);
			ShowThreadInfo();
			Console.WriteLine($"task10s end at {DateTime.Now}");
			return 2;
		}
	}
}
