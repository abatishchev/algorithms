using System;
using System.Linq;

namespace Algorithms
{
	public class BreadthFirstTraversal
	{
		public static void Do(TreeNode root, Action<TreeNode> visitor)
		{
			var queue = new Queue<TreeNode> { root };
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

	class Queue<T> : System.Collections.Generic.Queue<T>
	{
		public void Add(T item)
		{
			Enqueue(item);
		}
	}
}