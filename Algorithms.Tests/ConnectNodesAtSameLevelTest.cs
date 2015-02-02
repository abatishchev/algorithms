using System;
using Xunit;

namespace Algorithms.Tests
{
	public class ConnectNodesAtSameLevelTest : ConnectNodesAtSameLevel
	{
		[Theory]
		[InlineData("ABCDEFGHIJKLMNOP")]
		public void ConnectTreeNodesAtSameLevel(string data)
		{
			TreeNode root = CreateTreeNode.Do(data);

			Do(root);

			throw new NotImplementedException();
		}
	}
}