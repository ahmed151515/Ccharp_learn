using System.Runtime.Serialization;

namespace archive.Serialization
{
	public class _2_BinarySerialization
	{
		public static void Main()
		{
			var e = new Employee(1, "ahmed", 9999, "IT", new List<string> { "p1", "p2" });

			var binaryFormat = SerializeBinaryString(e);

			Employee e2 = DeSerializeFromBinaryString(binaryFormat);
			e2.Print();
		}

		private static Employee DeSerializeFromBinaryString(string binaryFormat)
		{
			byte[] binary = Convert.FromBase64String(binaryFormat);
			using (var stream = new MemoryStream(binary))
			{
				var serialize = new DataContractSerializer(typeof(Employee));


				return serialize.ReadObject(stream) as Employee;
			}
		}

		private static string SerializeBinaryString(Employee e)
		{
			using (var stream = new MemoryStream())
			{
				/*
				 * In the tutorial I see that he uses BinaryFormatter but it is blocked
				 * I will use DataContractSerializer
				*/
				//var binaryFormater = new BinaryFormatter();
				var serialize = new DataContractSerializer(e.GetType());
				serialize.WriteObject(stream, e);
				stream.Flush();
				stream.Position = 0;

				return Convert.ToBase64String(stream.ToArray());
			}
		}
	}
}
