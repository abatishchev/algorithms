using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class BreadthFirstTraversal
	{
		public static void Do(TreeNode root, Action<TreeNode> visitor)
		{
			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Any())
			{
				TreeNode current = queue.Dequeue();

				if (current.Left != null)
				{
					queue.Enqueue(current.Left);
				}
				if (current.Right != null)
				{
					queue.Enqueue(current.Right);
				}

				visitor(current);
			}
		}
	}
}