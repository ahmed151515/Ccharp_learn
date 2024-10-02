namespace archive.Threading
{
	public class Wallet
	{
		private readonly object BitCoinsLock = new object(); // case RaceCondition to lock resources
		public Wallet(string name, int bitCoins)
		{
			Name = name;
			BitCoins = bitCoins;
		}

		public string Name { get; private set; }
		public int BitCoins { get; private set; }

		public void Debit(int amount)
		{
			lock (BitCoinsLock) // case RaceCondition to lock resources
			{
				if (BitCoins >= amount)
				{
					Thread.Sleep(1000);
					BitCoins -= amount;
					//PrintThreadData(amount); use with RaceCondition Sequential Multithread
				}
			}

		}

		public void Credit(int amount)
		{
			lock (BitCoinsLock) // case RaceCondition to lock resources
			{

				Thread.Sleep(1000);
				BitCoins += amount;
				//PrintThreadData(amount); use with RaceCondition Sequential Multithread
			}
		}

		private void PrintThreadData(int amount)
		{
			Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId} "
				+ $"Thread Name: {Thread.CurrentThread.Name} " +
				$"Processor Id: {Thread.GetCurrentProcessorId()} amount: {amount}");
		}

		public void RunRandomTransactions()
		{
			int[] amuonts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20, };

			foreach (var amount in amuonts)
			{
				var absValue = Math.Abs(amount);
				if (amount < 0)
				{
					Debit(absValue);
				}
				else
				{
					Credit(absValue);
				}

			}
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			return $"{Name} -> {BitCoins}";
		}
	}

}