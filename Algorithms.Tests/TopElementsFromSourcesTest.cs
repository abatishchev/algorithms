using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class TopElementsFromSourcesTest : TopElementsFromSources
	{
		[Theory]
		[MemberData("GetData")]
		public void TopElementsFromSources(int[][] sources, int[] expected)
		{
			var actual = GetTopElements(3, sources);

			if (expected != null)
			{
				actual.ShouldBeEquivalentTo(expected);
			}
		}


		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[]
				{
					new[] { 1, 2, 3 },
					new[] { 3, 4, 5 },
					new[] { 2, 3, 4 }
				},
				new[] { 1, 2, 2 }
			};

			var random = new Random();
			var sources = Enumerable.Range(0, 10)
			                        .Select(s => random.Next(0, 100))
			                        .Select(r => new { Low = r, High = random.Next(r, random.Next(r + 1, 100)) })
			                        .Select(x => Enumerable.Range(x.Low, x.High)
			                                               .OrderBy(i => i)
			                                               .ToArray())
			                        .ToArray();
			yield return new object[] { sources, null };
		}
	}
}