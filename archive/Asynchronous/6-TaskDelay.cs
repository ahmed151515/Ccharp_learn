namespace archive.Asynchronous
{
	public class TaskDelay
	{
		public static void Main()
		{
			DelayUsingTask(5000);
			//SleepUsingThread(5000);


			Console.ReadKey();
		}
		static void DelayUsingTask(int ms)
		{
			Task.Delay(ms).ContinueWith((task) =>
			{
				Console.WriteLine($"Completed Delay {ms}");

			});
		}
		static void SleepUsingThread(int ms)
		{
			Thread.Sleep(ms);
			Console.WriteLine($"Completed Sleep {ms}");
		}
	}
}
