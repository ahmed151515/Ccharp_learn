#nullable enable annotations // good way to handel lagacy code

using System.Diagnostics.CodeAnalysis;

namespace archive.Working_with_NULL
{
	public class _12_NullableContext
	{
		public static void Main()
		{
			/* In the project configuration, you can set Nullable as follows:

				<Nullable>warnings</Nullable> 
				This option enables warnings when dereferencing nullable values
				without checking for null.

				<Nullable>annotations</Nullable> 
				This option allows the use of nullable values
				without showing warnings when dealing with them.
*/

			string fname = null; //read from user
			string lname = null; //read from user
			Person person = new Person(fname.ToUpper(), lname.ToUpper());
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

#nullable restore annotations