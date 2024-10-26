namespace archive.Working_with_NULL
{
	public class _11_StructAndArray
	{
		public static void Main()
		{
			// compiler no Warnings in

			// case 1 struct with referenc type
			Print(default);

			// case 2
			string[] names = new string[10];
			var fname = names[0];

			//Console.WriteLine(fname.ToUpper());
		}

		static void Print(Student student)
		{
			Console.WriteLine($"first name: {student.fname.ToUpper()}");
			Console.WriteLine($"mid name: {student.mname?.ToUpper()}");
			Console.WriteLine($"last name: {student.lname.ToUpper()}");
		}


		struct Student
		{
			public string fname;
			public string? mname;
			public string lname;
		}
	}


}
