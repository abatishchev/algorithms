using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class TreeNodeBuilderTest : TreeNodeBuilder
	{
		[Theory]
		[MemberData("GetData")]
		public void TreeNodeBuilder(TreeNodeInfo[] arr)
		{
			var actual = DeserializeTree(arr);
			actual.Should().NotBeNull();
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[]
				{
					new TreeNodeInfo { Child = 50, Parent = 80, IsLeft = false },
					new TreeNodeInfo { Child = 70, Parent = 30, IsLeft = false },
					new TreeNodeInfo { Child = 80, Parent = 30, IsLeft = true },
					new TreeNodeInfo { Child = 30, Parent = null, IsLeft = true },
					new TreeNodeInfo { Child = 40, Parent = 80, IsLeft = true },
				}
			};
		}
	}
}