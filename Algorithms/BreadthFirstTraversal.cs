using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class BreadthFirstTraversal
	{
		public static void Do(TreeNode root, Action<TreeNode> visitor)
		{
			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				TreeNode current = queue.Dequeue();
				if (current == null)
					continue;
				queue.Enqueue(current.Left);
				queue.Enqueue(current.Right);

				visitor(current);
			}
		}
	}
}