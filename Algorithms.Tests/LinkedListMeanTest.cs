using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class LinkedListMeanTest : LinkedListMean
	{
		[Theory, PropertyData("GetData")]
		public void LinkedListMean(Node root, string meanValue)
		{
			Node mean = Do(root);

			Assert.Equal(mean.Value, meanValue);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateLinkedList.Do("FOO"), "O" };
			}
		}
	}
}