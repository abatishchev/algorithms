namespace Algorithms
{
	public class SumChildNodes
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
}