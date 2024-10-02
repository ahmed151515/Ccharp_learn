namespace archive.Asynchronous
{
	public class TaskContinuation
	{
		public static void Main()
		{
			var task = Task.Run(() => CountPrimeNumberInRange(1, 3_000_000));

			//Console.WriteLine(task.Result); // bad, for it is Blocks Main thread until task ends

			// continuation

			//var awaiter = task.GetAwaiter();
			//awaiter.OnCompleted(() =>
			//{
			//	Console.WriteLine(awaiter.GetResult()); // block the thread, but thread is ended
			//});

			// task.ContinueWith
			task.ContinueWith((primes) => Console.WriteLine(primes.Result)); // block the thread, but thread is ended

			Console.WriteLine("Main Thread");
			Console.ReadKey();
		}

		static int CountPrimeNumberInRange(int min, int max)
		{
			var count = 0;

			for (int i = min; i < max; i++)
			{
				var j = 2;
				var IsPrime = true;
				while (j <= (int)Math.Sqrt(i))
				{
					if (i % j == 0)
					{
						IsPrime = false;
						break;
					}
					++j;
				}
				if (IsPrime)
				{
					++count;
				}
			}
			return count;
		}
	}
}
