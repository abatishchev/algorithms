using System;

namespace Algorithms
{
	public class Wildcard2 : IWildcard
	{
		public bool ExpressionMatches(string text, string pattern)
		{
			if (String.IsNullOrEmpty(text)) throw new ArgumentNullException(text);
			if (String.IsNullOrEmpty(pattern)) throw new ArgumentNullException(pattern);

			return ExpressionMatches(text, pattern, 0, 0);
		}

		private static bool ExpressionMatches(string text, string pattern, int t, int p)
		{
			while (p < pattern.Length) // a*b a0b0
			{
				if (pattern[p] == '*')
				{
					if ((p < pattern.Length && ExpressionMatches(text, pattern, t, p + 1)) ||
						(t < text.Length && ExpressionMatches(text, pattern, t + 1, p)))
					{
						return true;
					}
				}

				if (p < pattern.Length && t < text.Length)
				{
					if (pattern[p++] != text[t++])
					{
						return false; // a*b a0c
					}
				}
				else
				{
					return false;
				}
			}
			// abc abc -> true
			// abc abd -> false
			return p == pattern.Length && t == text.Length;
		}
	}
}