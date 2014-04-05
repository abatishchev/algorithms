using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	public class ReverseString
	{
		public static string Do1(string str)
		{
			return new string(Reverse(str).ToArray());
		}

		private static IEnumerable<char> Reverse(string str)
		{
			for (int i = str.Length - 1; i >= 0; i--)
			{
				yield return str[i];
			}
		}

		public static string Do2(string str)
		{
			var sb = new StringBuilder(str.Length);
			for (int i = str.Length - 1; i >= 0; i--)
			{
				sb.Append(str[i]);
			}
			return sb.ToString();
		}

		public static string Do3(string str)
		{
			return new string(Reverse(str.ToCharArray()));
		}

		private static char[] Reverse(char[] arr)
		{
			int l = arr.Length;
			int m = l / 2;
			for (int i = m; i > 0; i--)
			{
				Swap(arr, m - i, m + i - 1);
			}
			return arr;
		}

		private static void Swap(char[] arr, int i, int j)
		{
			char t = arr[i];
			arr[i] = arr[j];
			arr[j] = t;
		}

		public static string Do4(string str)
		{
			char[] arr = str.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}

		public static string Do5(string str)
		{
			char[] arr = str.Reverse()
							.ToArray();
			return new string(arr);
		}
	}
}