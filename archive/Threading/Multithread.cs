
namespace archive.Threading
{
	public class MultiThread
	{
		public static void Main()
		{
			Thread.CurrentThread.Name = "Main Thread";
			var w = new Wallet("ahmed", 80);
			var t1 = new Thread(w.RunRandomTransactions);
			t1.Name = "t1";
			t1.Start();
			t1.Join();
			var t2 = new Thread(w.RunRandomTransactions);
			t2.Name = "t2";
			t2.Start();

			Console.ReadKey();
		}
	}




}
