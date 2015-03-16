using System;
using Xunit;

namespace Algorithms.Tests
{
	public class ConnectNodesAtSameLevelTest : ConnectNodesAtSameLevel
	{
		[Theory]
		[InlineData("ABCDEF")]
		public void ConnectTreeNodesAtSameLevel(string data)
		{
			TreeNode root = new TreeNode('A')
			{
				Left = new TreeNode('B')
				{
					Left = new TreeNode('D'),
					Right = new TreeNode('E')
				},
				Right = new TreeNode('C')
				{
					Left = new TreeNode('F'),
					Right = new TreeNode('G')
				}
			};

			SpeficyNext(root);

			var e = FindTreeNode.Find(root, 'E');
			var f = FindTreeNode.Find(root, 'F');

			Assert.Equal(e.Next.Value, f.Value);
		}
	}
}