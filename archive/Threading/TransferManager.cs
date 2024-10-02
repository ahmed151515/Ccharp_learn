namespace archive.Threading
{
	class TransferManager
	{
		private Wallet from;
		private Wallet to;
		private int amountToTransfer;

		public TransferManager(Wallet from, Wallet to, int amountToTransfer)
		{
			this.from = from;
			this.to = to;
			this.amountToTransfer = amountToTransfer;
		}

		public void Transfer()
		{

			// Arrangement the locks
			var lock1 = from.Name.CompareTo(to.Name) < 0 ? from : to;
			var lock2 = from.Name.CompareTo(to.Name) < 0 ? to : from;
			Console.WriteLine($"Thraed {Thread.CurrentThread.Name} is trying to lock Wallet {from} in {DateTime.Now}");
			// lock (from)  
			lock (lock1)
			{
				Console.WriteLine($"Thraed {Thread.CurrentThread.Name} is lock acquire Wallet {from} in {DateTime.Now}");
				Thread.Sleep(1000);
				Console.WriteLine($"Thraed {Thread.CurrentThread.Name} is trying to lock Wallet {to} in {DateTime.Now}");

				// it is maybe do deadlock in worst case
				//lock (to)
				//{
				//	from.Debit(amountToTransfer);
				//	to.Credit(amountToTransfer);
				//}

				// solution Monitor (i see it in vidoe but when i use it is not usefl)
				//if (Monitor.TryEnter(to, 1000))
				// but i see you can merge between  solutions Monitor and Arrangement
				// to can handle when process failure
				if (Monitor.TryEnter(lock2, 1000))
				{
					try
					{

						from.Debit(amountToTransfer);
						to.Credit(amountToTransfer);
					}
					finally
					{
						Monitor.Exit(lock2);
						Console.WriteLine($"-- Thread {Thread.CurrentThread.Name} done secssfily --");
					}
				}
				else
				{

					Console.WriteLine($"## Thraed {Thread.CurrentThread.Name} is unable to lock Wallet {to} in {DateTime.Now}##");
				}


				// solution Arrangement the locks
				//lock (lock2)
				//{
				//	from.Debit(amountToTransfer);
				//	to.Credit(amountToTransfer);
				//}
			}
		}
	}
}
