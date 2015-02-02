using System;
using System.Collections.Generic;
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

		public static void DoWithLevel(TreeNode root, Action<TreeNode> visitor)
		{
			int level = 0;

			var queue = new Queue<Tuple<TreeNode, int>>();
			queue.Enqueue(Tuple.Create(root, level));

			while (queue.Count != 0)
			{
				var current = queue.Dequeue();
				if (current.Item1 == null)
					continue;

				queue.Enqueue(Tuple.Create(current.Item1.Left, level));
				queue.Enqueue(Tuple.Create(current.Item1.Right, level));

				visitor(current.Item1);
				level++;
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