namespace Algorithms
{
	public interface IWildcard
	{
		bool ExpressionMatches(string text, string pattern);
	}
}