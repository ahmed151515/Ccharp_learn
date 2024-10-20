

namespace archive.Records
{
	public class _1_ValueBasedEquality
	{
		public static void Main()
		{
			var p1 = new Point_s(1, 2);
			var p2 = new Point_s(1, 2);

			Console.WriteLine($"{nameof(p1)} ({p1.x},{p1.y})");
			Console.WriteLine($"{nameof(p2)} ({p2.x},{p2.y})");

			Console.WriteLine($"p1 Equals p2: {p1.Equals(p2)}");

		}
	}


	struct Point_s
	{
		public int x;
		public int y;

		public Point_s(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
