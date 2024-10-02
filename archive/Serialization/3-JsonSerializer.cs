using Newtonsoft.Json;
using System.Text.Json;

namespace archive.Serialization
{
	public class _3_JsonSerializer
	{
		public static void Main()
		{
			var e = new Employee(1, "ahmed", 9999, "IT", new List<string> { "p1", "p2" });

			Console.WriteLine("-------Newtonsoft.json-------");
			string jsonFormat = SerializeJsonStringUsingNewtonsoft(e);
			Console.WriteLine(jsonFormat);
			var e2 = DeSerializeJsonStringUsingNewtonsoft(jsonFormat);
			Console.WriteLine();
			e2.Print();
			Console.WriteLine("-------Json.net-------");
			string jsonFormat2 = SerializeJsonStringUsingJSONNet(e);
			Console.WriteLine(jsonFormat2);
			var e3 = DeSerializeJsonStringUsingJSONNet(jsonFormat2);
			Console.WriteLine();
			e3.Print();
		}
		// use third party libary Newtonsoft.json
		private static string SerializeJsonStringUsingJSONNet(Employee e)
			=> System.Text.Json.JsonSerializer.Serialize(e, new JsonSerializerOptions { WriteIndented = true });

		private static Employee DeSerializeJsonStringUsingJSONNet(string jsonFormat)
			=> System.Text.Json.JsonSerializer.Deserialize<Employee>(jsonFormat);

		private static string SerializeJsonStringUsingNewtonsoft(Employee e)
			=> JsonConvert.SerializeObject(e, Formatting.Indented);

		private static Employee DeSerializeJsonStringUsingNewtonsoft(string jsonFormat)
			=> JsonConvert.DeserializeObject<Employee>(jsonFormat);

	}
}
