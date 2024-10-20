namespace archive.Records
{
	public class _6_PropertyInitSetter
	{
		public static void Main()
		{
			var p1 = new Point(1, 2);
			var p2 = new Point(1, 2);
			var p3 = new Point
			{
				x = 4,
				y = 5
			};




			Console.WriteLine($"(p1 == p2): {(p1 == p2)}");
			Console.WriteLine($"p1 Equals p2: {p1.Equals(p2)}");


		}
		class Point : IEquatable<Point>
		{
			public int x { get; init; }
			public int y { get; init; }

			public Point()
			{
			}

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

			public static bool operator ==(Point l, Point r)
			{
				if (l is null)
				{
					if (r is null)
					{
						return true;
					}
					return false;
				}

				return l.Equals(r);
			}
			public static bool operator !=(Point l, Point r)
			{
				if (l is null)
				{
					if (r is null)
					{
						return true;
					}
					return false;
				}
				return l.Equals(r);
			}
		}
	}
}

