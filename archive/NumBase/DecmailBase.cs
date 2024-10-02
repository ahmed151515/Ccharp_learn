namespace archive.NumBase
{
	public class DecmailBase : NumBase
	{
		public DecmailBase(string source)
		{
			source.ValidateNumBase(NumBaseEnum.Decmail);
			Value = source;
		}
	}
}
