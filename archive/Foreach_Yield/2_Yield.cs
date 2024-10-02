namespace archive.Foreach_Yield
{
	public class _2_Yield
	{
		public static void Main()
		{
			Console.WriteLine("Using GenerateV1()");
			foreach (var item in GenerateV1())
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine("\n\nUsing GenerateV2()");
			foreach (var item in GenerateV2())
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine("\n\nUsing GenerateV3()");
			foreach (var item in GenerateV3())
			{
				Console.Write($"{item} ");
			}
		}

		static IEnumerable<int> GenerateV1()
		{
			var result = new List<int>();
			for (int i = 1; i <= 5; i++)
			{
				result.Add(i);
			}
			return result;
		}
		static IEnumerable<int> GenerateV2()
		{

			for (int i = 1; i <= 5; i++)
			{
				yield return i;
			}

		}
		static IEnumerable<int> GenerateV3()
		{

			yield return 1;
			Console.WriteLine("return 1");
			yield return 2;
			Console.WriteLine("return 2");
			yield return 3;
			Console.WriteLine("return 3");
			yield return 4;
			Console.WriteLine("return 4");
			yield return 5;
			Console.WriteLine("return 5");


		}
	}
}
