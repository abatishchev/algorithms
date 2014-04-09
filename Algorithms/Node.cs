using System;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{Value}")]
	public class Node
	{
		public Node(string value = null)
		{
			Value = value;
		}

		public Node(int value)
			: this(value.ToString())
		{
		}

		public string Value;

		public Node Next;

		private static Node New(Func<Tuple<bool, string>> func)
		{
			Tuple<bool, string> t;

			Node root = null;
			while ((t = func()).Item1)
			{
				root = new Node
				{
					Value = t.Item2,
					Next = root
				};
			}
			return root;
		}

		public static Node New(bool isLooped)
		{
			int i = 0;

			Node root = New(() => new Tuple<bool, string>(i++ <= 5, i.ToString()));

			root.Next.Next.Next = isLooped ? root : null;

			return root;
		}

		public static Node New(string str)
		{
			str = ReverseString.Do1(str);

			using (var e = str.GetEnumerator())
			{
				return New(() =>
					{
						bool moveNext = e.MoveNext();
						return new Tuple<bool, string>(moveNext, moveNext ? e.Current.ToString() : "");
					});
			}
		}
	}
}