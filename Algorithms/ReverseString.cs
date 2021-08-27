using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	public interface IReverse
	{
		string Reverse(string input);
	}

	public class ReverseString1 : IReverse
	{
		public string Reverse(string input)
		{
			char[] arr = Reverse(input.ToCharArray()).ToArray();
			return new string(arr);
		}

		private static IEnumerable<char> Reverse(IList<char> input)
		{
			for (int i = input.Count - 1; i >= 0; i--)
			{
				yield return input[i];
			}
		}
	}

	public class ReverseString2 : IReverse
	{
		public string Reverse(string input)
		{
			var sb = new StringBuilder(input.Length);
			for (int i = input.Length - 1; i >= 0; i--)
			{
				sb.Append(input[i]);
			}
			return sb.ToString();
		}
	}

	public class ReverseString3 : IReverse
	{
		public string Reverse(string input)
		{
			return new string(Reverse(input.ToCharArray()));
		}

		private static char[] Reverse(char[] arr)
		{
			int l = arr.Length;
			int m = l / 2;
			for (int i = m; i > 0; i--)
			{
				arr.Swap(m - i, m + i - 1);
			}
			return arr;
		}
	}

	public class ReverseString4 : IReverse
	{
		public string Reverse(string input)
		{
			char[] arr = input.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}

	public class ReverseString5 : IReverse
	{
		public string Reverse(string input)
		{
			char[] arr = input.Reverse().ToArray();
			return new string(arr);
		}
	}
}