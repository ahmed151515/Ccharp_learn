namespace archive.Threading
{
	public class DeadLock
	{
		public static void Main()
		{
			Thread.CurrentThread.Name = "Main";
			var w1 = new Wallet("ahmed", 100);
			var w2 = new Wallet("arafa", 100);
			var w3 = new Wallet("mohmmed", 100);
			var w4 = new Wallet("arrm", 100);
			var transfer1 = new TransferManager(w1, w2, 50);
			var transfer2 = new TransferManager(w2, w1, 50);
			var transfer3 = new TransferManager(w3, w2, 50);
			var transfer4 = new TransferManager(w4, w1, 50);

			var t1 = new Thread(transfer1.Transfer);
			var t2 = new Thread(transfer2.Transfer);
			var t3 = new Thread(transfer3.Transfer);
			var t4 = new Thread(transfer4.Transfer);

			t1.Name = "T1";
			t2.Name = "T2";
			t3.Name = "T3";
			t3.Name = "T4";

			t1.Start();
			t2.Start();
			t3.Start();
			t4.Start();

			t1.Join();
			t2.Join();
			t3.Join();
			t4.Join();

			Console.WriteLine(w1);
			Console.WriteLine(w2);
			Console.WriteLine(w3);
			Console.WriteLine(w4);
			Console.ReadKey();
		}
	}
}
