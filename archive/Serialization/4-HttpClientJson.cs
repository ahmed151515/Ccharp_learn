using Newtonsoft.Json;

namespace archive.Serialization
{
	public class _4_HttpClientJson
	{
		readonly static HttpClient http = new HttpClient();
		public static async Task Main()
		{
			string url = "https://jsonplaceholder.typicode.com/todos";

			var todesJsonFormat = await http.GetStringAsync(url);

			var todoes = JsonConvert.DeserializeObject<List<Todo>>(todesJsonFormat);
			foreach (var todo in todoes)
			{
				Console.WriteLine(todo);
			}
		}
	}

	public class Todo
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; }
		public bool Completed { get; set; }

		public override string ToString()
		{
			return $"{Id} | {UserId} | {Title} | {Completed}";
		}
	}

}
