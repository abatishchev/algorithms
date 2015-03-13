using System;
using System.Linq;

namespace Algorithms
{
	public class TreeNodeBuilder
	{
		public TreeNode DeserializeTree(TreeNodeInfo[] arr)
		{
			if (arr == null) throw new ArgumentNullException("arr");
			if (arr.Length == 0) throw new ArgumentException("Arr is empty");

			var rootInfo = FindRoot(arr);
			if (rootInfo == null) throw new ArgumentException("Arr doesn't contain a tree root");

			var rootNode = new TreeNode(rootInfo.Child);
			DeserializeTree(arr, rootNode, rootInfo);
			return rootNode;
		}

		private static void DeserializeTree(TreeNodeInfo[] arr, TreeNode node, TreeNodeInfo info)
		{
			var children = FindNodes(arr, info);

			var left = children[0];
			if (left != null)
			{
				node.Left = new TreeNode(left.Child);
				DeserializeTree(arr, node.Left, left);
			}

			var right = children[1];
			if (right != null)
			{
				node.Right = new TreeNode(right.Child);
				DeserializeTree(arr, node.Right, right);
			}
		}

		private static TreeNodeInfo[] FindNodes(TreeNodeInfo[] arr, TreeNodeInfo node)
		{
			return new[]
			{
				arr.SingleOrDefault(n => n.Parent == node.Child && n.IsLeft),
				arr.SingleOrDefault(n => n.Parent == node.Child && !n.IsLeft) // O(n) where n = arr.Length
			};
		}

		private static TreeNodeInfo FindRoot(TreeNodeInfo[] arr)
		{
			return arr.SingleOrDefault(n => !n.Parent.HasValue);
		}
	}
}