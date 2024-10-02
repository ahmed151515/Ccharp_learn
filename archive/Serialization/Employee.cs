using System.Runtime.Serialization;

namespace archive.Serialization
{
	[DataContract]
	public class Employee
	{
		public Employee()
		{

		}

		public Employee(int id, string name, decimal salarry, string dep, List<string> projects)
		{
			Id = id;
			Name = name;
			Salarry = salarry;
			Dep = dep;
			Projects = projects;
		}

		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public decimal Salarry { get; set; }
		[DataMember]
		public string Dep { get; set; }
		[DataMember]
		public List<string> Projects { get; set; }
		public void Print()
		{
			Console.WriteLine(Id);
			Console.WriteLine(Name);
			Console.WriteLine(Salarry);
			Console.WriteLine(Dep);
			foreach (var project in Projects)
			{
				Console.Write($"{project}, ");

			}
			Console.WriteLine();
		}
	}
}
