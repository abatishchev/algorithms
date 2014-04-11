using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class CreateTreeNode
	{
		public static TreeNode Do(string data)
		{
			return Do(data.AsEnumerable().Cast<object>());
		}

		private static TreeNode Do(IEnumerable<object> data)
		{
			TreeNode node = new TreeNode(Pop(ref data));
			TreeNode root = node;

			foreach (object v in data)
			{
				if (node == null)
					break;

				node.Left = CreateNode(node, ref data);
				node.Right = CreateNode(node, ref data);

				node = node.Left;
			}

			return root;
		}

		private static TreeNode CreateNode(TreeNode parent, ref IEnumerable<object> data)
		{
			object value = Pop(ref data);
			return value != null ?
					   new TreeNode(value) { Parent = parent } :
					   null;
		}

		private static object Pop(ref IEnumerable<object> data)
		{
			object value = data.FirstOrDefault();

			data = data.Skip(1);

			return value;
		}
	}
}
