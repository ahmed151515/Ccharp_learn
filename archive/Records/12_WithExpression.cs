namespace archive.Records
{
	public class _12_WithExpression
	{
		public static void Main()
		{
			var p1 = new Point(1, 2);

			var p2 = new Point(5, p1.y);

			var p3 = p1 with { x = 5 };

			Console.WriteLine(p1);
			Console.WriteLine(p2);
			Console.WriteLine(p3);
		}

		record Point(int x, int y);
	}
}
