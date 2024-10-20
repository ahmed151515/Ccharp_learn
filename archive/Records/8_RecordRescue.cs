namespace archive.Records
{
	public class _8_RecordRescue
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
			public int x;
			public int y;

			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}
	}
}
