namespace archive.Asynchronous
{
	public class TaskReturnsValue
	{
		public static void Main()
		{

			//Task<DateTime> task1 = Task.Run(ReturnDateTime);

			//Console.WriteLine(task1.Result);

			//Task<int> task2 = Task.Run(BlockThread);

			//Console.WriteLine(task2.Result); // The task.Result until Result is ready


		}

		private static DateTime ReturnDateTime() => DateTime.Now;
		private static int BlockThread()
		{
			while (true)
			{

			}
			return 5;
		}
	}
}
