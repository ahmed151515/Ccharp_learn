namespace archive.Records
{
	public class _4_OverrideEquality
	{
		public static void Main()
		{
			var p1 = new Point(1, 2);
			var p2 = new Point(1, 2);

			Console.WriteLine($"{nameof(p1)} ({p1.x},{p1.y})");
			Console.WriteLine($"{nameof(p2)} ({p2.x},{p2.y})");
			Console.WriteLine($"p1 Equals p2: {p1.Equals(p2)}");

			var points = new Dictionary<Point, string>();

			//points.Add(p1, $"({p1.x},{p1.y})");
			//points.Add(p2, $"({p2.x},{p2.y})");
		}
		class Point : IEquatable<Point>
		{
			public int x;
			public int y;

			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			public override bool Equals(object? obj)
			{
				var point = obj as Point;

				return Equals(point);
			}

			public bool Equals(Point? point)
			{
				if (point is null)
				{
					return false;
				}
				return point.x == x && point.y == y;
			}

			public override int GetHashCode()
			{
				//int hash = 7;

				//hash = hash * 14 + x.GetHashCode();
				//hash = hash * 17 + y.GetHashCode();

				//return hash;

				return HashCode.Combine(x, y);
			}
		}

	}

}
