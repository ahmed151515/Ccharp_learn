namespace archive.Working_with_NULL
{
	public class _9_NullableValueAnnotations
	{
		public static void Main()
		{
			string fname = null!;
			string lname = null!;

			var person = new Person(fname, lname);
			Console.WriteLine(person.FirstName!.Length);
		}
		class Person
		{

			public string? FirstName { get; set; }
			public string? LastName { get; set; }
			public Person(string firstName, string lastName)
			{
				FirstName = firstName ?? "Annonymous";
				LastName = lastName ?? "Annonymous";
			}
		}
	}
}
