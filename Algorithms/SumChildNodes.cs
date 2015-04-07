namespace Algorithms
{
	public class SumChildNodes1
	{
		public void UpdateTreeNode(TreeNode<int> node)
		{
			if (node == null)
				return;

			UpdateTreeNode(node.Left);
			UpdateTreeNode(node.Right);

			if (node.Left != null)
				node.Value += node.Left.Value;
			if (node.Right != null)
				node.Value += node.Right.Value;
		}
	}

	public class SumChildNodes2
	{
		public int UpdateTreeNode(TreeNode<int> node)
		{
			if (node == null)
				return 0;

			node.Value += UpdateTreeNode(node.Left);
			node.Value += UpdateTreeNode(node.Right);

			return node.Value;
		}
	}
}