using archive.Serialization;

namespace app
{
	public class Program
	{
		static LinkedList<string> Values = new LinkedList<string>();
		//public static void Main(string[] args)
		public static async Task Main(string[] args)
		{
			//Sequential.Main();
			//MultiThread.Main();
			//RaceCondition.Main();
			//DeadLock.Main();
			//UseThreadPool.Main();

			//ThreadVsTasks.Main();
			//TaskReturnsValue.Main();
			//LongRunningTask.Main();
			//ExceptionPropagation.Main();
			//TaskContinuation.Main();
			//TaskDelay.Main();
			//SyncVsAsync.Main();
			//AsyncFunctions.ArchiveMain();
			//var i = 0;
			//while (true)
			//{
			//	if (AsyncFunctions.ended == true)
			//	{
			//		AsyncFunctions.ShowThreadInfo();
			//		Console.WriteLine("task ended");
			//		break;
			//	}

			//}
			//AsyncFunctions.ShowThreadInfo();
			//archive.Asynchronous.CancellationToken.Main().Wait();
			//ReportProgress.Main().Wait();
			//TaskCombinators.Main().Wait();
			//ConcurrencyAndParallelism.Main().Wait();

			//_1_XMLSerialization.Main();
			//_2_BinarySerialization.Main();
			//_3_JsonSerializer.Main();
			_4_HttpClientJson.Main().Wait();





			//var set = new Thread(SetData);
			//var get = new Thread(GetData);
			//set.Start();
			//get.Start();

			//Task.Run(SetData);
			//Task.Run(GetData).Wait();



		}

		static void SetData()
		{
			string data;
			while (true)
			{
				data = Console.ReadLine();
				Values.AddLast(data);
			}
		}
		static void GetData()
		{
			int size = Values.Count;

			while (true)
			{
				if (size < Values.Count)
				{
					Console.WriteLine(Values.Last.Value);
					size++;
				}
				else
				{
					continue;
				}
			}
		}


	}

}