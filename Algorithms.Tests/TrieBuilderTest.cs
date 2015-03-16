using System.Linq;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class TrieBuilderTest : TrieBuilder
	{
		//          \0
		//   a      r     k
		// n m l    o	  r
		// n m e   b d	  i
		//   y x     g    s
		//           e
		//           r

		[Theory]
		[InlineData("ann,ammy,rob,rodger,kris,alex")]
		public void TrieBuilder(string input)
		{
			string[] words = input.Split(',').Select(x => x.Trim()).ToArray();

			var root = Build(words);

			root.Value.Should().Be('\0');
			root.Nodes.Should().HaveCount(3); // a, r, k

			root.Nodes[0].Value.Should().Be('a');
			root.Nodes[0].Nodes.Should().HaveCount(3); // n(n), m(my)

			root.Nodes[1].Value.Should().Be('r');
			root.Nodes[1].Nodes.Should().HaveCount(1); // o
			root.Nodes[1].Nodes[0].Nodes.Should().HaveCount(2); // b, d(ger)

			root.Nodes[2].Value.Should().Be('k');
			root.Nodes[2].Nodes.Should().HaveCount(1); // r(is)
		}
	}
}