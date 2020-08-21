using _02_KarateChop_NetCore;
using System.Collections.Generic;
using Xunit;

namespace KarateChop.Tests.Unit
{
    public class RecursiveUnitTest
    {
        [Theory]
        [InlineData(-1, 3, new int[] { })]
        [InlineData(0, 1, new int[] { 1, 3, 5 })]
        [InlineData(1, 3, new int[] { 1, 3, 5 })]
        [InlineData(2, 5, new int[] { 1, 3, 5 })]
        [InlineData(-1, 0, new int[] { 1, 3, 5 })]
        [InlineData(-1, 2, new int[] { 1, 3, 5 })]
        [InlineData(-1, 4, new int[] { 1, 3, 5 })]
        [InlineData(-1, 6, new int[] { 1, 3, 5 })]
        [InlineData(0, 1, new int[] { 1, 3, 5, 7 })]
        [InlineData(1, 3, new int[] { 1, 3, 5, 7 })]
        [InlineData(2, 5, new int[] { 1, 3, 5, 7 })]
        [InlineData(3, 7, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 0, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 2, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 4, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 6, new int[] { 1, 3, 5, 7 })]
        [InlineData(2, 30, new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 })]
        public void Test1(int expected, int target, int[] sortedNumbers)
        {
            Assert.Equal(expected, new RecursiveChop().Chop(target, sortedNumbers));
        }
    }
}
