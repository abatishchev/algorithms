using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class ConnectNodesAtSameLevel
	{
		public static void Do(TreeNode root)
		{
			int i = 1, j = 0;

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Any())
			{
				if (Math.Log(++i, 2) % 1 == 0)
				{
					j++;
				}

				TreeNode current = queue.Dequeue();

				if (current.Level != j)
				{
				}

				if (current.Left != null)
				{
					current.Left.Level = j;
					queue.Enqueue(current.Left);
				}
				if (current.Right != null)
				{
					current.Right.Level = j;
					queue.Enqueue(current.Right);
				}
			}
		}
	}
}