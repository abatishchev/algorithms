using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class NthOrderStatisticsTest : NthOrderStatistics
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void Do(int[] arr, int expected)
        {
            int actual = Median(arr);

            Assert.Equal(actual, expected);
        }

        public static IEnumerable<object[]> GetData
        {
            get
            {
                yield return new object[] { new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 5 };
            }
        }
    }
}