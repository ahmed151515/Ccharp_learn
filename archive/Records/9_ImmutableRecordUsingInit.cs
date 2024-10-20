namespace archive.Records
{
	public class _9_ImmutableRecordUsingInit
	{
		public static void Main()
		{
			var p1 = new Point(1, 2);
			var p2 = new Point(1, 2);

			Console.WriteLine($"p1 Equals p2: {p1.Equals(p2)}");
			Console.WriteLine($"p1 == p2: {p1 == p2}");

			Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
			Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");

			Console.WriteLine(p1);
			Console.WriteLine(p2);
		}
		record Point
		{
			public int x { get;/*you can use init keyword*/ }

			public int y { get; /*you can use init keyword*/ }

			//public int x { get; init; }
			// but create non-pramter constrctor
			//public int y { get; init; }
			public Point()
			{

			}

			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}
	}
}
