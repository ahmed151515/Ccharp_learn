
public class Employee
{
	/// <summary>
	/// ctor
	/// </summary>
	/// <param name="id"> id </param>
	/// <param name="name"> name</param>
	/// <param name="salarry">salry</param>
	/// <param name="dep">department</param>
	public Employee(int id, string name, decimal salarry, string dep)
	{
		Id = id;
		Name = name;
		Salarry = salarry;
		Dep = dep;
	}

	public int Id { get; set; }
	public string Name { get; set; }
	public decimal Salarry { get; set; }
	public string Dep { get; set; }

	public override bool Equals(object? obj)
	{
		if (obj == null || !(obj is Employee))
		{
			return false;
		}
		else
		{
			var e = (Employee)obj;
			return Id == e.Id && Name == e.Name && Salarry == e.Salarry && Dep == e.Dep;
		}
	}

	public static bool operator ==(Employee l, Employee r) => l.Equals(r);
	public static bool operator !=(Employee l, Employee r) => l.Equals(r);

	public override int GetHashCode()
	{
		int hash = 13;

		hash = (hash * 7) + Id.GetHashCode();
		hash = (hash * 7) + Name.GetHashCode();
		hash = (hash * 7) + Salarry.GetHashCode();
		hash = (hash * 7) + Dep.GetHashCode();
		return hash;
	}

	public void Print()
	{
		Console.WriteLine(Id);
		Console.WriteLine(Name);
		Console.WriteLine(Salarry);
		Console.WriteLine(Dep);
	}

}
