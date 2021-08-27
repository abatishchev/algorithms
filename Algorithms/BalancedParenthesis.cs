using System;
using System.Linq;

namespace Algorithms
{
	public class BalancedParenthesis
	{
		public bool Do1(string input)
		{
			return IsBalanced(input, "");
		}

		private static readonly char[] Opened = "([<{".ToCharArray();
		private static readonly char[] Closed = ")]>}".ToCharArray();

		private static bool IsOpened(char ch)
		{
			return Opened.Contains(ch);
		}

		private static bool IsClosed(char ch)
		{
			return Closed.Contains(ch);
		}

		private static bool IsMatching(char chOpen, char chClose)
		{
			return Array.IndexOf(Opened, chOpen) == Array.IndexOf(Closed, chClose);
		}

		private static bool IsBalanced(string input, string stack)
		{
			if (input.Length == 0)
			{
				return stack.Length == 0;
			}
			else
			{
				if (IsOpened(input[0]))
				{
					return IsBalanced(input.Substring(1), input[0] + stack);
				}
				else
				{
					if (IsClosed(input[0]))
					{
						return stack.Length != 0 && IsMatching(stack[0], input[0]) && IsBalanced(input.Substring(1), stack.Substring(1));
					}
					else
					{
						return IsBalanced(input.Substring(1), stack);
					}
				}
			}
		}
	}
}