using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class LeastRecentlyUsedCacheTest
	{
		[Fact]
		public void LeastRecentlyUsedCache()
		{
			var cache = new LeastRecentlyUsedCache<char>(3);

			cache.Add('A');
			cache.Add('B');
			cache.Add('C');
			cache.Add('D');

			cache.Count.Should().Be(3);
			cache.Contains('A').Should().BeFalse();
			cache.Oldest.Should().Be('B');

			cache.Remove('D');

			cache.Count.Should().Be(2);
			cache.Contains('D').Should().BeFalse();

			var x = cache['B'];
			cache.Newest.Should().Be(x);
		}
	}
}