using System.Runtime.CompilerServices;
using System.Text;

namespace archive.Strings
{
	public class _L02
	{
		public static void Main()
		{
			Task.Run(GetAssciFormatAsyc).Wait();
			Task.Run(GetUTF8FormatAsyc).Wait();
		}

		private static string GetThisFilePath([CallerFilePath] string path = null)
		{
			return path;
		}


		static async Task GetAssciFormatAsyc()
		{
			var filePath = Path.Combine(GetThisFilePath(), "..\\assci_data.txt");

			using (var client = new HttpClient())
			{
				Uri uri = new Uri("https://ar.wikipedia.org/wiki/%D8%A7%D9%84%D8%B5%D9%81%D8%AD%D8%A9_%D8%A7%D9%84%D8%B1%D8%A6%D9%8A%D8%B3%D8%A9");
				using (HttpResponseMessage response = await client.GetAsync(uri))
				{
					var bytes = await response.Content.ReadAsByteArrayAsync();
					var result = Encoding.ASCII.GetString(bytes);
					File.WriteAllText(filePath, result);
				}
			}
		}
		static async Task GetUTF8FormatAsyc()
		{
			var filePath = Path.Combine(GetThisFilePath(), "..\\UTF8_data.txt");

			using (var client = new HttpClient())
			{
				Uri uri = new Uri("https://ar.wikipedia.org/wiki/%D8%A7%D9%84%D8%B5%D9%81%D8%AD%D8%A9_%D8%A7%D9%84%D8%B1%D8%A6%D9%8A%D8%B3%D8%A9");
				using (HttpResponseMessage response = await client.GetAsync(uri))
				{
					var bytes = await response.Content.ReadAsByteArrayAsync();
					var result = Encoding.UTF8.GetString(bytes);
					File.WriteAllText(filePath, result);

				}
			}
		}
	}
}
