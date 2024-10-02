namespace archive.Threading
{
	public class Sequential
	{
		public static void Main()
		{
			var wallet = new Wallet("ahmed", 80);

			wallet.RunRandomTransactions();
			Console.WriteLine("-------");
			Console.WriteLine(wallet);

			Console.WriteLine("-------");
			wallet.RunRandomTransactions();
			Console.WriteLine("-------");
			Console.WriteLine(wallet);
		}
	}
}
