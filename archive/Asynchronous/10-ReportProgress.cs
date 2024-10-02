namespace archive.Asynchronous
{
	public class ReportProgress
	{
		public static async Task Main()
		{
			Action<int> progress = (p) => { Console.Clear(); Console.WriteLine($"{p}%"); };
			await Copy(progress);
		}

		static Task Copy(Action<int> OnProgressChanged)
		{
			return Task.Run(() =>
			{
				for (int i = 0; i <= 100; i++)
				{
					Task.Delay(50).Wait();
					if (i % 10 == 0)
					{
						OnProgressChanged(i);
					}
				}
			});
		}
	}
}
