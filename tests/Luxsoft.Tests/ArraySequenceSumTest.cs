using System;
using Luxsoft.Library;
using Xunit;

namespace Luxsoft.Tests
{
    public class ArraySequenceSumTest
    {
        [Theory]
        [InlineData(124, 130, 8, new[] {125})]
        [InlineData(10, 20, 5, new[] {14})]
        [InlineData(10, 20, 55, new int[] {})]
        public void TestValidNumbers(int min, int max, int sum, int[] expected)
        {
            var result = new ArraySequenceSum(min, max, sum).GetResultAsArray();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(120, 120)]
        [InlineData(120, 110)]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void TestInvalidArguments(int min, int max)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new ArraySequenceSum(min, max, 0);
            });
        }
    }
}