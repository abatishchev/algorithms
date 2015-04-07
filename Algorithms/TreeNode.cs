using System;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("{ToString()}")]
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

		public int Level { get; set; }

		public TreeNode Next { get; set; }

		public override string ToString()
		{
			return String.Format("Value={0}, Left={1}, Right={2}", ToString(this), ToString(Left), ToString(Right));
		}

		private static string ToString(TreeNode node)
		{
			return (node != null && node.Value != null ? node.Value : "null").ToString();
		}
	}

	[DebuggerDisplay("{Value}")]
	public class TreeNode<T>
	{
		public TreeNode(T value)
		{
			Value = value;
		}

		public T Value { get; set; }

		public TreeNode<T> Left { get; set; }

		public TreeNode<T> Right { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as TreeNode<T>;
			if (other == null)
				return false;

			return Value.Equals(other.Value) &&
				   (Left == null || Left.Equals(other.Left)) &&
				   (Right == null || Right.Equals(other.Right));
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}
	}

	public class TreeNodeInfo
	{
		public int Child { get; set; }

		public int? Parent { get; set; }

		public bool IsLeft { get; set; }
	}
}