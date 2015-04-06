using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class LinkListLoopedTest
	{
		[Theory]
		[MemberData("GetData")]
		public void LinkListLooped(Type t, LinkedNode root, bool expected)
		{
			dynamic x = Activator.CreateInstance(t);

			bool actual = x.IsLooped(root);

			actual.Should().Be(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[] { typeof(LinkListLooped1), CreateLinkedList.Do(), false };
			yield return new object[] { typeof(LinkListLooped2), CreateLinkedList.Do(), false };

			LinkedNode looped = CreateLinkedList.Do();
			looped.Next.Next = looped;

			yield return new object[] { typeof(LinkListLooped1), looped, true };
			yield return new object[] { typeof(LinkListLooped2), looped, true };
		}
	}
}