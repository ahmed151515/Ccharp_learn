using System.Diagnostics.CodeAnalysis;

namespace archive.Working_with_NULL
{
	public class _8_CompilerDoesNotTraceMethod
	{
		public static void Main()
		{

		}
		class Person
		{
			public Person(string firstName, string lastName)
			{
				FirstName = firstName;
				LastName = lastName;
			}

			public string FirstName { get; set; }
			public string LastName { get; set; }

		}
		class Student : Person
		{

			public string Major { get; set; }

			public Student(string firstName, string lastName, string major)
				: base(firstName, lastName)
			{
				SetMajor(major);
			}
			public Student(string firstName, string lastName)
				: base(firstName, lastName)
			{
				SetMajor();
			}
			[MemberNotNull(nameof(Major))]
			void SetMajor(string? major = default)
			{
				Major = major ?? "Undeclared";
			}
		}
	}




}
