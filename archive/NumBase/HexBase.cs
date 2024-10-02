namespace archive.NumBase
{
	public class HexBase : NumBase
	{
		public HexBase(string source)
		{
			source.ValidateNumBase(NumBaseEnum.Hex);
			Value = source;
		}
	}
}
