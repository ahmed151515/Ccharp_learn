namespace archive.Asynchronous
{
	public class TaskCombinators
	{
		static Random random = new Random();
		static int num => random.Next(1, 5);
		public static async Task Main()
		{
			var has1000SubcriberWithAny = Task.Run(Has1000Subscriber);
			var has4000ViewHoursWithAny = Task.Run(Has4000ViewHours);
			Console.WriteLine("Using WhenAny()");
			Console.WriteLine("--------------");
			var any = await Task.WhenAny(has1000SubcriberWithAny, has4000ViewHoursWithAny);
			Console.WriteLine(any.Result);
			Console.WriteLine("--------------");
			Console.WriteLine("Using WhenAll()");
			Console.WriteLine("---------------");
			var has1000SubcriberWithAll = Task.Run(Has1000Subscriber);
			var has4000ViewHoursWithAll = Task.Run(Has4000ViewHours);
			var all = await Task.WhenAll(has4000ViewHoursWithAll, has1000SubcriberWithAll);
			foreach (var result in all)
			{
				Console.WriteLine(result);
			}
		}

		static Task<string> Has1000Subscriber()
		{
			Task.Delay(num * 1000).Wait();
			return Task.FromResult("Congratulation !! you have 1000 subscribers");
		}
		static Task<string> Has4000ViewHours()
		{
			Task.Delay(num * 1000).Wait();
			return Task.FromResult("Congratulation !! you have 4000 view hours");
		}
	}
}
