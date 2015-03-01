using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class Wildcard
	{
		public int GetNumberOfOccurrences(string pattern, string input)
		{
			var rules = GetRules(pattern).ToArray();

			var substrings = GetSubstrings(input).ToArray();

			var macthes = GetMacthes(substrings, rules).ToArray();

			return macthes.Count();
		}

		private static IEnumerable<Rule> GetRules(string pattern)
		{
			return pattern.Select(CreateRule);
		}

		private static Rule CreateRule(char ch, int i)
		{
			switch (ch)
			{
				case '*':
					return new WildcardRule(ch, i);
				default:
					return new Rule(ch, i);
			}
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

		private static IEnumerable<string> GetMacthes(string[] substrings, Rule[] rules)
		{
			return substrings.Where(substring =>
									{
										return rules.All(r => r.IsMatch(substring));
									});
		}
	}

	public class WildcardRule : Rule
	{
		public WildcardRule(char ch, int i)
			: base(ch, i)
		{
		}

		public override bool IsMatch(string substring)
		{
			return true;
		}
	}

	public class Rule
	{
		public Rule(char ch, int i)
		{
			Character = ch;
			Position = i;
		}

		public char Character { get; private set; }

		public int Position { get; private set; }

		public virtual bool IsMatch(string substring)
		{
			if (String.IsNullOrEmpty(substring))
				throw new ArgumentNullException("substring");

			if (substring.Length < Position + 1)
				return false;

			return substring[Position] == Character;
		}
	}
}