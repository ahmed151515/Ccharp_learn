namespace archive.Working_with_NULL
{
	public class _2_ReferencingVsDereferencing
	{
		public static void Main()
		{
			// reference type default value is null 
			string s1 = default; // = s1 = null
			string s2 = "a";

			// dereferencing follows the reference to access
			// the object
			Console.WriteLine(s2.Length);
			//Console.WriteLine(s1.Length); // this will throw a NullReferenceException


			// value type
			DateTime date = default; // default value is 1/1/0001 12:00:00 AMs
			Console.WriteLine(date.Month);


		}
	}


}
