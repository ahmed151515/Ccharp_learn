namespace archive.NumBase
{
	public class OctalBase : NumBase
	{
		public OctalBase(string source)
		{
			source.ValidateNumBase(NumBaseEnum.Octal);
			Value = source;
		}
	}
}
