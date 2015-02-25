using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class StringPermutations
	{
		public IEnumerable<string> GetStringPermutations(string input)
		{
			var output = new List<string>();
			GetStringPermutations(input, String.Empty, output);
			return output;
		}

		private static void GetStringPermutations(string input, string remaining, ICollection<string> output)
		{
			if (String.IsNullOrEmpty(input))
			{
				// recursion exit condition
				output.Add(remaining);
				return;
			}

			for (int i = 0; i < input.Length; i++)
			{
				string substring = String.Concat(input.Substring(0, i), input.Substring(i + 1));
				GetStringPermutations(substring, remaining + input[i], output);
			}
		}
	}
}