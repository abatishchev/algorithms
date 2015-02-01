using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class PostOrderTraversalTree
	{
		public static string Do(TreeNode node)
		{
			return String.Concat(InOrder(node));
		}

		private static IEnumerable<object> InOrder(TreeNode node)
		{
			if (node == null)
				yield break;

			foreach (object v in InOrder(node.Left))
			{
				yield return v;
			}

			foreach (object v in InOrder(node.Right))
			{
				yield return v;
			}

			yield return node.Value;
		}
	}
}