using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class HeapTest
	{
		[Fact]
		public void TestAdd()
		{
			var heap = new Heap<int>((a, b) => a < b);

			heap.Add(50);
			heap.Add(30);
			heap.Add(40);
			heap.Add(28);
			heap.Add(32);
			heap.Add(38);
			heap.Add(42);

			heap[1].Should().Be(32);
			heap[3].Should().Be(28);
			heap[4].Should().Be(30);

			heap.Add(35);

			heap[1].Should().Be(35);
			heap[3].Should().Be(32);
			heap[4].Should().Be(30);
			heap[7].Should().Be(28);
		}
	}
}