﻿using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class TreeToLinkedListTest : TreeToLinkedList
	{

		[Theory, PropertyData("GetData")]
		public void TreeToLinkedList(TreeNode tree, string expected)
		{
			Node list = Do(tree);

			string actual = list.ToString(false, "");

			Assert.Equal(actual, expected);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateTreeNode.Do("ABCDEF"), "FDBEAC" };
			}
		}
	}
}