namespace archive.Records
{
	public class _10_PositionalRecord
	{
		public static void Main()
		{
			var p1 = new Point(1, 2);
			var p2 = new Point(1, 2);

			//p1.y = 10; // the Positional Record is by default immutable

			Console.WriteLine($"p1 Equals p2: {p1.Equals(p2)}");
			Console.WriteLine($"p1 == p2: {p1 == p2}");


			Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
			Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");

			var (x, y) = p1;

			Console.WriteLine($"x = {x},y = {y}");

			Console.WriteLine(p1);
			Console.WriteLine(p2);
		}
		//record Point(int x, int y);

		record Point(int x, int y)
		{
			public Point() : this(0, 0)
			{
			}
		}

	}
}
