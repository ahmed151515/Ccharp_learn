namespace archive.Working_with_NULL
{
	public class _3_NullableValueTypes
	{
		public static void Main()
		{
			int mark1 = 30;
			int mark2 = default(int); // default = 0
									  // but zero maybe your mark is 0 or you don't have a mark

			Nullable<int> mark3 = default; // null

			if (mark3 is null)
			{
				Console.WriteLine("Not available!");
			}
			else
			{
				Console.WriteLine(mark3);
			}

			int? mark4 = default; // null

			if (!mark4.HasValue)
			{
				Console.WriteLine("Not available!");
			}
			else
			{
				Console.WriteLine(mark4);
			}

			Nullable<int> mark5 = default; // null
			Console.WriteLine($"mark5 = {(mark5.HasValue ? mark5 : "null")}");

			Nullable<int> mark6 = new Nullable<int>(); // null
			Console.WriteLine($"mark6 = {(mark6.HasValue ? mark6 : "null")}");

			int? mark7 = default(int?); // null
			Console.WriteLine($"mark7 = {(mark7.HasValue ? mark7 : "null")}");

			Nullable<int> mark8 = new(); // 0
			Console.WriteLine($"mark8 = {(mark8.HasValue ? mark8 : "null")}");
		}
	}
}
