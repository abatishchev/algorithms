using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
	public class CreateLinkedListTest : CreateLinkedList
	{
		[Theory, MemberData("GetData")]
		public void CreateLinkedList(int depth)
		{
			LinkedNode root = Do(depth);

			int i = 0;
			do
			{
				i++;
			} while ((root = root.Next) != null);

			Assert.Equal(i, depth);
		}

		public static IEnumerable<object[]> GetData
		{
			get
			{
				yield return new object[] { 1 };
				yield return new object[] { 10 };
			}
		}
	}
}