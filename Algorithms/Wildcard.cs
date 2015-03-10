using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class Wildcard : IWildcard
	{
		public int GetNumberOfOccurrences(string input, string pattern)
		{
			var substrings = GetSubstrings(input).ToArray();
			var macthes = GetMacthes(substrings, pattern).ToArray();
			return macthes.Count();
		}

		private static IEnumerable<string> GetSubstrings(string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				for (int j = i + 1; j <= input.Length; j++)
				{
					yield return input.Substring(i, j - i);
				}
			}
		}

		private static IEnumerable<string> GetMacthes(string[] substrings, string pattern)
		{
			return substrings.Where(substring => ExpressionMatches(substring, pattern, 0, 0));
		}

		public bool ExpressionMatches(string text, string pattern)
		{
			return ExpressionMatches(text, pattern, 0, 0);
		}

		private static bool ExpressionMatches(string input, string pattern, int i, int p)
		{
			while (p < pattern.Length)
			{
				// Single wildcard character
				if (pattern[p] == '*')
				{
					// Need to do some tricks.

					// 1. The wildcard  is ignored. 
					//    So just an empty string matches. This is done by recursion.
					//      Because we eat one character from the match string, the
					//      recursion will stop.

					// 2. Chance we eat the next character and try it again, with a
					//    wildcard  match. This is done by recursion. Because we eat
					//      one character from the string, the recursion will stop.

					if (ExpressionMatches(input, pattern, i, p + 1) ||
					    (i < input.Length - 1 && ExpressionMatches(input, pattern, i + 1, p)))
						return true;

					// Nothing worked with this wildcard.
					return false;
				}
				if (i < input.Length && p < pattern.Length)
				{
					// Standard compare of 2 chars. Note that pszSring might be 0
					// here, but then we never get a match on pszMask that has always
					// a value while inside this loop.
					if (input[i++] != pattern[p++])
						return false;
				}
				else return false;
			}

			// Have a match? Only if both are at the end...
			return i == input.Length && p == pattern.Length;
		}
	}
}