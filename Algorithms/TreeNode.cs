using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{Value}")]
	public class TreeNode
	{
		public TreeNode()
		{
		}

		public TreeNode(object value)
		{
			Value = value;
		}

		public object Value;

		public TreeNode Left;

		public TreeNode Right;

		public TreeNode Parent;
	}
}