using System;

namespace Algorithms
{
	public class FindLessOrEqualNode
	{
		public static TreeNode<double> FindLessOrEqual(TreeNode<double> node, double value)
		{
			if (node == null)
				return null;
			if (node.Value == value)
				return node;
			if (node.Value > value)
			{
				var left = FindLessOrEqual(node.Left, value);
				return left != null ? left : node;
			}
			if (node.Value < value)
			{
				var right = FindLessOrEqual(node.Right, value);
				return right != null ? right : node;
			}
			return null;
		}
	}
}