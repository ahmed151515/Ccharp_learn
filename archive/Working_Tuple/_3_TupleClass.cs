namespace archive.Working_Tuple
{
	public class _3_TupleClass
	{
		public static void Main()
		{
			Console.WriteLine("Get FacilityInfo using Tuple.Create");

			var facilityInfo = FacilityDistanceCalculator.CalculateFacilityDistance("Hospital");

			Console.WriteLine(facilityInfo);

			Console.WriteLine("Get FacilityInfo using Tuple Constructor");

			var facilityInfoV2 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");

			Console.WriteLine(facilityInfoV2);

			Console.WriteLine("Get FacilityInfo using Tuple.Create / Access Item");

			var facilityInfoV3 = FacilityDistanceCalculator.CalculateFacilityDistanceV3("Hospital");
			Console.WriteLine($"{facilityInfoV3.Item1} ....... {facilityInfoV3.Item2.ToString("F2")} km");

			// Equality

			var t1 = Tuple.Create("hospial1", 2.5);
			var t2 = Tuple.Create("hospial1", 2.5);


			(string name, double dis) = t1;

			Console.WriteLine($"{name} {dis}");

			Console.WriteLine(t1.Equals(t2));

		}

		public static class FacilityDistanceCalculator
		{
			private static Random random = new Random();
			public static Tuple<string, double> CalculateFacilityDistance(string facilityName)
			{
				return Tuple.Create(facilityName, Math.Round(random.NextDouble() * 10, 2));
			}

			public static Tuple<string, double> CalculateFacilityDistanceV2(string facilityName)
			{
				return new Tuple<string, double>(facilityName, Math.Round(random.NextDouble() * 10, 2));
			}

			public static Tuple<string, double> CalculateFacilityDistanceV3(string facilityName)
			{
				return Tuple.Create(facilityName, Math.Round(random.NextDouble() * 10, 2));
			}
		}
	}

}
