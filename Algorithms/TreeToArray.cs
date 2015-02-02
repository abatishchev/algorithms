using System.Collections.Generic;

namespace Algorithms
{
	public class TreeToArray
	{
		public static TreeNode[] Do(TreeNode root)
		{
			var arr = new TreeNode[root.Length + 1];
			Do(arr, root, 0);
			return arr;
		}

		private static void Do(IList<TreeNode> arr, TreeNode node, int level)
		{
			if (node == null) return;

			if (level == 0)
				arr[level] = node;

			if (node.Left != null)
			{
				arr[2 * level + 1] = node.Left;
				Do(arr, node.Left, level + 1);
			}
			if (node.Right != null)
			{
				arr[2 * level + 2] = node.Right;
				Do(arr, node.Right, level + 1);
			}
		}
	}
}