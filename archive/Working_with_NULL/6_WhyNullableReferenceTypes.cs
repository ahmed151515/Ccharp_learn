namespace archive.Working_with_NULL
{
	public class _6_WhyNullableReferenceTypes
	{
		public static void Main()
		{
			string? name = null;
			string decision = IsLongName(name) ? "long" : "short";
			string decision2 = IsLongNameNotNull(name) ? "long" : "short";
			Console.WriteLine($"{name} is {decision}");
		}
		static bool IsLongName(string? name)
		{


			return name.Length > 10; // assumption name could be null 

		}
		static bool IsLongNameNotNull(string name)
		{
			if (name is null)
				return false;

			return name.Length > 10;

		}
	}
}
