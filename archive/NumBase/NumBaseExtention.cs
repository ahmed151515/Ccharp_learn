namespace archive.NumBase
{
	public static class NumBaseExtention
	{
		public static void ValidateNumBase(this string source, NumBaseEnum numBaseEnum)
		{
#if DEBUG
			Console.WriteLine("test is Vaild");
#endif
			var allwod = allwodChar[numBaseEnum];
			foreach (var ch in source)
			{
				if (!allwod.Contains(char.ToLower(ch)))
				{
					throw new InvalidOperationException($"the source it is invalid cher not in {allwod} for base {numBaseEnum}");
				}
			}

		}

		public static string To<T>(this T source, NumBaseEnum numBaseEnum) where T : NumBase
		{
			int fromBase;
			switch (source)
			{
				case BinaryBase: fromBase = (int)NumBaseEnum.Binary; break;
				case OctalBase: fromBase = (int)NumBaseEnum.Octal; break;
				case DecmailBase: fromBase = (int)NumBaseEnum.Decmail; break;
				case HexBase: fromBase = (int)NumBaseEnum.Hex; break;
				default: throw new InvalidOperationException();
			}
			return Convert.ToString(Convert.ToUInt32(source.Value, fromBase), (int)numBaseEnum).ToUpper();

		}

		private static Dictionary<NumBaseEnum, string> allwodChar = new Dictionary<NumBaseEnum, string>
			(
			new List<KeyValuePair<NumBaseEnum, string>>
			{
				new KeyValuePair<NumBaseEnum, string>(NumBaseEnum.Binary, "01"),
				new KeyValuePair<NumBaseEnum, string>(NumBaseEnum.Octal, "01234567"),
				new KeyValuePair<NumBaseEnum, string>(NumBaseEnum.Decmail, "0123456789"),
				new KeyValuePair<NumBaseEnum, string>(NumBaseEnum.Hex, "0123456789abcdef"),
			}
			);
	}
}
