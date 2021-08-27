using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class BuildOrderTest : BuildOrder
	{
		[Theory]
		[MemberData(nameof(GetData))]
		public void BuildOrder(ICollection<Operation> ops, ICollection<OperationDependency> deps, IEnumerable<IEnumerable<Operation>> expected)
		{
			var actual = FindBuildOrder(ops, deps).ToArray();

			actual.Should().BeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				"ABCDMNXYZ".ToOperationList(),
				"B-A, C-A, D-C, Y-X, Z-Y".ToDependencynList(),
				"ABCD, M, N, XYZ".ToBuildOrder(),
			};
		}
	}

	internal static class StringExtensions
	{
		public static Operation[] ToOperationList(this string input)
		{
			return input.Select(o => new Operation(o.ToString()))
						.ToArray();
		}

		public static OperationDependency[] ToDependencynList(this string input)
		{
			return input.Split(',')
						.Select(p => p.Trim())
						.Select(p => p.Split('-'))
						.Select(a => new OperationDependency(a[0], a[1]))
						.ToArray();
		}

		public static Operation[][] ToBuildOrder(this string input)
		{
			return input.Split(',')
						.Select(p => p.Trim())
						.Select(p => p.Select(c => c.ToString())
									  .Select(c => new Operation(c.ToString()))
									  .ToArray())
						.ToArray();
		}
	}
}