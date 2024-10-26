using System.Diagnostics;
using System.Text;
namespace archive.Working_StringBuilder
{
	public class L01_MutableStringBuilder
	{
		public static void Main()
		{
			Task.Run(LoopString);
			Task.Run(LoopStringBuilder);

			Console.ReadKey();
		}

		static void LoopString()
		{
			var stopwatch = new Stopwatch();
			var s = "";
			stopwatch.Start();
			for (int i = 0; i < 200_000; i++)
			{
				s += "a";
			}
			stopwatch.Stop();
			Console.WriteLine($"String has time: {stopwatch.Elapsed}");

		}
		static void LoopStringBuilder()
		{
			var stopwatch = new Stopwatch();
			var sb = new StringBuilder();
			stopwatch.Start();
			for (long i = 0; i < 200_000; i++)
			{
				sb.Append("ad");
			}
			stopwatch.Stop();
			Console.WriteLine($"StringBuilder has time: {stopwatch.Elapsed}");


		}


		static string GenerateWithString()
		{
			string str = null;

			str += String.Concat(new char[] { 'E', 'T', 'I' }); // ETI

			str += String.Format("GAT{0}{1}{2}", 'O', 'P', 'S'); // GATOPS

			str = "M" + str; // METIGATOPS

			str = str.Replace('P', 'R'); //METIGATORS

			str = str.Remove(str.Length - 1); // METIGATOR 

			return str;
		}
		static string GenerateWithStringBuilder()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(new char[] { 'E', 'T', 'I' }); // ETI

			sb.AppendFormat("GAT{0}{1}{2}", 'O', 'P', 'S'); // ETIGATOPS

			sb.Insert(0, "M"); // METIGATOPS

			sb.Replace('P', 'R'); //METIGATORS

			sb.Remove(sb.Length - 1, 1); // METIGATOR 

			return sb.ToString();
		}
	}
}
