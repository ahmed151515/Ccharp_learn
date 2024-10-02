using System.Xml;
using System.Xml.Serialization;

namespace archive.Serialization
{
	public class _1_XMLSerialization
	{
		public static void Main()
		{
			var e = new Employee(1, "ahmed", 9999, "IT", new List<string> { "p1", "p2" });
			var xmlFormat = SerializerXmlString(e);

			//Console.WriteLine(xmlFormat);
			//File.WriteAllText("C:\\Users\\PC\\Desktop\\VS_projects\\ccharp_learn\\archive\\Serialization\\XmlDoc.xml"
			//	, xmlFormat);
			//SerializerXmlFile(e);

			Employee e2 = DeSerializerFromFile();

			e2.Print();



		}

		private static Employee DeSerializerFromXmlString(string xmlFormat)
		{
			Employee e = null;
			var xmlSerializer = new XmlSerializer(typeof(Employee));

			using (TextReader textReader = new StringReader(xmlFormat))
			{
				e = xmlSerializer.Deserialize(textReader) as Employee;
			}

			return e;
		}
		private static Employee DeSerializerFromFile()
		{
			Employee e = null;
			var xmlSerializer = new XmlSerializer(typeof(Employee));

			using (FileStream file = File.OpenRead("C:\\Users\\PC\\Desktop\\VS_projects\\ccharp_learn\\archive\\Serialization\\XmlDoc.xml"))
			{
				e = xmlSerializer.Deserialize(file) as Employee;
			}

			return e;
		}

		private static string SerializerXmlString(Employee e)
		{
			string result;

			var xlmSerializer = new XmlSerializer(e.GetType());

			using (var sw = new StringWriter())
			{
				using (var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true }))
				{
					xlmSerializer.Serialize(xmlWriter, e);
					result = sw.ToString();
				}
			}

			return result;
		}
		private static void SerializerXmlFile(Employee e)
		{
			// has a proplm on ?xml tag it is append with every object

			var xlmSerializer = new XmlSerializer(e.GetType());

			using (var f = new FileStream("C:\\Users\\PC\\Desktop\\VS_projects\\ccharp_learn\\archive\\Serialization\\XmlDoc.xml"
				, FileMode.Append))
			{

				using (var xmlWriter = XmlWriter.Create(f, new XmlWriterSettings { Indent = true }))
				{
					xlmSerializer.Serialize(xmlWriter, e);

				}
			}


		}
	}
}
