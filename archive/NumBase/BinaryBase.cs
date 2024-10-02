namespace archive.NumBase
{
	public class BinaryBase : NumBase
	{
		public BinaryBase(string source)
		{
			source.ValidateNumBase(NumBaseEnum.Binary);
			Value = source;
		}
	}
}
