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

		public object Value { get; set; }

		public TreeNode Left { get; set; }

		public TreeNode Right { get; set; }

		public TreeNode Parent { get; set; }

		public int Length { get; set; }
	}
}