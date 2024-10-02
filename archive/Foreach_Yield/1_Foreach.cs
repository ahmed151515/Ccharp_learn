namespace archive.Foreach_Yield
{
	public class _1_Foreach
	{
		public static void Main()
		{
			int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Console.WriteLine("Using for");
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write($"{nums[i]} ");
			}

			Console.WriteLine("\n\nUsing Foreach");
			foreach (var num in nums)
			{
				Console.Write($"{num} ");
			}
			Console.WriteLine("\n\nUsing My Foreach");
			Foreach<int>(nums, (num) => Console.Write($"{num} "));


			Console.WriteLine("\n");
		}
		// CLR dont know foreach 
		static void Foreach<T>(IEnumerable<T> values, Action<T> action)
		{
			IEnumerator<T> enumerator = values.GetEnumerator();
			try
			{

				while (enumerator.MoveNext())
				{
					action(enumerator.Current);
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}
	}
}