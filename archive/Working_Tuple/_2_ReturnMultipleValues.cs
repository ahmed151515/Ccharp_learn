namespace archive.Working_Tuple
{
	public class _2_ReturnMultipleValues
	{
		public static void Main()
		{
			Console.WriteLine("Using Class DS");
			var facilityName = FacilityDistanceCalculator.GetFacilityLocationInfoV1("Hospital");
			Console.WriteLine(facilityName);

			Console.WriteLine();
			Console.WriteLine("Using out Parameter");

			string name = "";
			double distanceInKm = 0;

			FacilityDistanceCalculator
				.GetFacilityLocationInfoV2("Hospital", out name, out distanceInKm);

			Console.WriteLine($"{name} ....... {distanceInKm.ToString("F2")} km");
		}
		public class Location
		{
			public string Name { get; set; }
			public double DistanceInKm { get; set; }

			public override string ToString()
			{
				return $"{Name} ....... {DistanceInKm.ToString("F2")} km";
			}


		}
		public static class FacilityDistanceCalculator
		{
			private static Random random = new Random();
			public static Location GetFacilityLocationInfoV1(string facilityName)
			{
				return new Location
				{
					Name = facilityName,
					DistanceInKm = random.NextDouble() * 10.0
				};
			}

			public static void GetFacilityLocationInfoV2(
				string facilityName, out string name, out double distanceInKm)
			{
				name = facilityName;
				distanceInKm = random.NextDouble() * 10.0;
			}
		}
	}

}



