using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class StringPermutations1
	{
		public string[] GetPermutations(string input)
		{
			var output = new List<string>();
			GetPermutations(input, String.Empty, output);
			return output.ToArray();
		}

		private static void GetPermutations(string input, string remaining, ICollection<string> output)
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
				GetPermutations(substring, remaining + input[i], output);
			}
		}
	}

	public class StringPermutations2
	{
		public string[] GetPermutations(string input)
		{
			var output = new List<string>();
			GetPermutations(input, String.Empty, output);
			return output.ToArray();
		}

		private static void GetPermutations(string input, string temp, ICollection<string> output)
		{
			if (String.IsNullOrEmpty(input))
			{
				output.Add(temp);
				return;
			}

			for (int i = 0; i < input.Length; i++)
			{
				GetPermutations(input.Remove(i, 1), temp + input.Substring(i, 1), output);
			}
		}
	}
}