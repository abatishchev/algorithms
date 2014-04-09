using System.Collections.Generic;

using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
	public class CreateLinkedListTest : CreateLinkedList
	{
		[Theory, PropertyData("GetData")]
		public void CreateLinkedList(int depth)
		{
			Node root = Do(depth);

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