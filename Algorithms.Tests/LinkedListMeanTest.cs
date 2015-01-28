using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class LinkedListMeanTest : LinkedListMean
	{
		[Theory, MemberData("GetData")]
		public void LinkedListMean(Node root, string meanValue)
		{
			Node mean = Do1(root);

			Assert.Equal(mean.Value, meanValue);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { CreateLinkedList.Do("BAR"), "A" };
			}
		}
	}
}