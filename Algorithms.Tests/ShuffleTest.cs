using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class ShuffleTest
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void Shuffle(Type t, IList<int> values)
		{
			var sh = (IShuffle)Activator.CreateInstance(t);

			values = sh.Do(values);

			values.Should().NotBeInAscendingOrder()
			      .And.Subject.Should().NotBeInDescendingOrder();
		}

		public static IEnumerable<object[]> GetData()
		{
			Func<int[]> gen = () => Enumerable.Range(0, 25).ToArray();

			yield return new object[] { typeof(Shuffle1), gen() };
			yield return new object[] { typeof(Shuffle2), gen() };
		}
	}
}