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
			const int top = 3;

			var actual = GetTopElements(top, sources);

			if (expected == null)
			{
				expected = sources.SelectMany(i => i).OrderBy(i => i).Take(top).ToArray();
			}
			actual.ShouldBeEquivalentTo(expected);
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

			//var random = new Random();
			//var sources = Enumerable.Range(0, 3)
			//						.Select(s => random.Next(0, 50))
			//						.Select(r => new { Low = r, High = random.Next(r, random.Next(r + 1, r + 25)) })
			//						.Select(x => Enumerable.Range(x.Low, x.High)
			//											   .OrderBy(i => i)
			//											   .ToArray())
			//						.ToArray();
			//yield return new object[] { sources, null };
		}
	}
}