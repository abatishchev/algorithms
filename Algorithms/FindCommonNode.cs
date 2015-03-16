namespace Algorithms
{
	public class FindCommonNode
	{
		public static TreeNode Find(TreeNode x, TreeNode y)
		{
			TreeNode t;
			while (true)
			{
				t = Compare(x, y);
				if (t != null)
					break;

				x = x.Parent;

				t = Compare(x, y);
				if (t != null)
					break;

				y = y.Parent;

				t = Compare(x, y);
				if (t != null)
					break;
			}

			return t;
		}

		private static TreeNode Compare(TreeNode x, TreeNode y)
		{
			if (x == null)
				return null;

			if (y == null)
				return null;

			if (x.Parent == y)
				return y;

			if (y.Parent == x)
				return x;

			return null;
		}
	}
}