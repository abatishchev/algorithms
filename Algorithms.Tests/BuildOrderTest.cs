using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class BuildOrderTest : BuildOrder
	{
		[Theory]
		[MemberData("GetData")]
		public void BuildOrder(ICollection<Operation> ops, ICollection<OperationDependency> deps, IEnumerable<IEnumerable<Operation>> expected)
		{
			var actual = FindBuildOrder(ops, deps).ToArray();

			actual.ShouldBeEquivalentTo(expected);
		}

		public static IEnumerable<object[]> GetData()
		{
			yield return new object[]
			{
				new[]
				{
					new Operation("A"),
					new Operation("B"),
					new Operation("C"),
					new Operation("D"),

					new Operation("M"),
					new Operation("N"),

					new Operation("X"),
					new Operation("Y"),
					new Operation("Z")
				},
				new[]
				{
					new OperationDependency("B", "A"),
					new OperationDependency("C", "A"),
					new OperationDependency("D", "C"),

					new OperationDependency("Y", "X"),
					new OperationDependency("Z", "Y")

				},
				new[]
				{
					new[]
					{
						new Operation("A"),
						new Operation("B"),
						new Operation("C"),
						new Operation("D")
					},
					new[]
					{
						new Operation("M"),
					},
					new[]
					{
						new Operation("N"),
					},
					new[]
					{
						new Operation("Z"),
						new Operation("Y"),
						new Operation("X")
					}
				}
			};
		}
	}
}