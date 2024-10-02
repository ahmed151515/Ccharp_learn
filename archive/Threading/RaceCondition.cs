namespace archive.Threading
{
	public class RaceCondition
	{
		public static void Main()
		{
			var w = new Wallet("ahmed", 50);
			var t1 = new Thread(() => w.Debit(40));
			var t2 = new Thread(() => w.Credit(40));
			t1.Name = "t1";
			t2.Name = "t2";
			t1.Start();
			t2.Start();

			t1.Join();
			t2.Join();

			Console.WriteLine(w);
			Console.ReadLine();
		}
	}
}
