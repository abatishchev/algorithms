using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithms
{
	public class ConnectNodesAtSameLevel
	{
		public static void SpecifyLevel(TreeNode root)
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

		public static void SpeficyNext(TreeNode root)
		{
			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Any())
			{
				TreeNode current = queue.Dequeue();

				if (current.Left != null && current.Right != null)
				{
					current.Left.Next = current.Right;

					if (current.Left.Right != null && current.Right.Left != null)
					{
						current.Left.Right.Next = current.Right.Left;
					}
				}

				if (current.Left != null)
				{
					queue.Enqueue(current.Left);
				}
				if (current.Right != null)
				{
					queue.Enqueue(current.Right);
				}
			}
		}
		public static void PopulateNextRecursive(TreeNode currentNode)
		{
			// If the left child is null, then it assumed that the right child should be null as well.
			if (currentNode.Left != null)
			{
				// For the left child we just set the right child as the next (even if it is null).
				currentNode.Left.Next = currentNode.Right;

				// As we never reference currentNode.Next.Next in our recursion, we can go straight to the left subtree
				// without setting the Next for the right node for now.
				PopulateNextRecursive(currentNode.Left);

				// If the right child is set.
				if (currentNode.Right != null)
				{
					// Here we're making sure that the current node's Next exists, so we can reference its left child.
					if (currentNode.Next != null)
					{
						currentNode.Right.Next = currentNode.Next.Left;
					}
					else
					{
						currentNode.Right.Next = null;
					}

					// Going to the right subtree
					PopulateNextRecursive(currentNode.Right);
				}
			}
		}
	}
}