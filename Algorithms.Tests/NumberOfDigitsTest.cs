using Xunit;

namespace Algorithms.Tests
{
	public class NumberOfDigitsTest : NumberOfDigits
	{
		[Theory]
		[InlineData(5)]
		[InlineData(12)]
		[InlineData(901)]
		public void NumberOfDigits(int num)
		{
			var actual = GetNumberOfDigits(num);

			Assert.Equal(actual, num.ToString().Length);
		}
	}
}