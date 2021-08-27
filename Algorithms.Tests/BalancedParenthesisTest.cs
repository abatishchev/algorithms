using Xunit;

namespace Algorithms.Tests
{
    public class BalancedParenthesisTest : BalancedParenthesis
    {
        [Theory]
        [InlineData("{{{{{{{{{{}}}}}}}}}}", true)]
        public void CheckParenthesis(string input, bool expected)
        {
            bool actual = Do1(input);

            Assert.Equal(actual, expected);
        }
    }
}