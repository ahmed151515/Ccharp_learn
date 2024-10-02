namespace archive.Asynchronous
{
	public class CancellationToken
	{

		public static async Task Main()
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

			//await DoCheck1(cancellationTokenSource);
			//await DoCheck2(cancellationTokenSource);
			await DoCheck3(cancellationTokenSource);
		}

		static async Task DoCheck1(CancellationTokenSource cancellationTokenSource)
		{
			_ = Task.Run(() =>
			{

				while (true)
				{
					var input = Console.ReadKey(true);
					if (input.Key == ConsoleKey.Q)
					{
						cancellationTokenSource.Cancel();
						Console.WriteLine("Task has been Cancelled !!!");
					}
				}
			});
			while (!cancellationTokenSource.Token.IsCancellationRequested)
			{
				Console.Write("Checking ... ");
				await Task.Delay(5000);
				Console.Write($"Completed at {DateTime.Now}\n");
			}

			Console.WriteLine("Check was Terminated");
			cancellationTokenSource.Dispose();
		}
		static async Task DoCheck2(CancellationTokenSource cancellationTokenSource)
		{
			_ = Task.Run(() =>
			{

				while (true)
				{
					var input = Console.ReadKey(true);
					if (input.Key == ConsoleKey.Q)
					{
						cancellationTokenSource.Cancel();
						Console.WriteLine("Task has been Cancelled !!!");
					}
				}
			});

			try
			{
				while (true)
				{
					Console.Write("Checking ... ");
					await Task.Delay(5000, cancellationTokenSource.Token); // if task is canceled the
																		   // daley is cansel also 
																		   // but exception is throw TaskCanceledException
					Console.Write($"Completed at {DateTime.Now}\n");
				}
			}

			catch
			{
				Console.WriteLine("Check was Terminated");
				cancellationTokenSource.Dispose();
			}


		}
		static async Task DoCheck3(CancellationTokenSource cancellationTokenSource)
		{
			_ = Task.Run(() =>
			{

				while (true)
				{
					var input = Console.ReadKey(true);
					if (input.Key == ConsoleKey.Q)
					{
						cancellationTokenSource.Cancel();
						Console.WriteLine("Task has been Cancelled !!!");
					}
				}
			});

			try
			{
				while (true)
				{
					cancellationTokenSource.Token.ThrowIfCancellationRequested();
					Console.Write("Checking ... ");
					await Task.Delay(5000);


					Console.Write($"Completed at {DateTime.Now}\n");
				}
			}

			catch (Exception e)
			{
				Console.WriteLine($"**{e.Message}**");
			}
			finally
			{
				Console.WriteLine("Check was Terminated");
				cancellationTokenSource.Dispose();

			}


		}
	}
}
