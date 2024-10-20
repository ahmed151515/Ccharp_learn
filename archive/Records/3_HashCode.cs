namespace archive.Records
{
	public class _3_HashCode
	{
		public static void Main()
		{
			var e1 = new Employee(100, "ahmed");
			var e2 = new Employee(100, "ahmed");
			Console.WriteLine(e1.GetHashCode());
			Console.WriteLine(e2.GetHashCode());
			Console.WriteLine("----------");
			var c1 = new Customer(100, "ahmed");
			var c2 = new Customer(100, "ahmed");
			Console.WriteLine(c1.GetHashCode());
			Console.WriteLine(c2.GetHashCode());
		}
	}

	class Employee
	{
		public Employee(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public int Id { get; set; }
		public string Name { get; set; }
	}
	struct Customer
	{
		public Customer(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public int Id { get; set; }
		public string Name { get; set; }
	}
}
