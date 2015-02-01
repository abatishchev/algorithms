using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class PreOrderTraversalTree
	{
		public static string Do(TreeNode node)
		{
			return String.Concat(PreOrder(node));
		}

		private static IEnumerable<object> PreOrder(TreeNode node)
		{
			if (node == null)
				yield break;

			yield return node.Value;

			foreach (object v in PreOrder(node.Left))
			{
				yield return v;
			}

			foreach (object v in PreOrder(node.Right))
			{
				yield return v;
			}
		}
	}
}