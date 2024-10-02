namespace archive.Asynchronous
{
	public class ExceptionPropagation
	{
		public static void Main()
		{
			try
			{
				//new Thread(ThrowExecuption).Start(); nnot catch
				Task.Run(ThrowExecuption).Wait();

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message + "\n----\n");
				Console.WriteLine(e.StackTrace + "\n----\n");
				Console.WriteLine(e.InnerException.Message + "\n----\n");
			}
			Console.WriteLine("main Thread end");
		}

		static void ThrowExecuption()
		{
			ThreadVsTasks.ShowThreadInfo();
			throw new NullReferenceException("Hi from task");
		}
	}
}
