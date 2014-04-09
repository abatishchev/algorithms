using System.Text;

namespace Algorithms
{
	public class LinkListPalindrome
	{
		public static bool Do1(Node root)
		{
			var sb = new StringBuilder();

			while (root != null)
			{
				sb.Append(root.Value);

				root = root.Next;
			}

			string str = sb.ToString();

			return str == ReverseString.Do1(str);
		}

		public static bool Do2(Node root)
		{
			Node mean = LinkedListMean.Do1(root);

			mean = ReverseLinkedList.Do1(mean);

			while (mean != null && root != null)
			{
				if (root.Value != mean.Value)
					return false;

				root = root.Next;
				mean = mean.Next;
			}

			return true;
		}
	}
}