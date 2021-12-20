using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class NoConstructibleChangeTest
    {
        [Theory]
        [InlineData(new int[]{ 1, 2, 5 }, 4)]
        [InlineData(new int[]{ 5,7,1,1,2,3,22 }, 20)]
        public void ValidateNoConstructibleChange(int[] coins, int expected)
        {
            var result = new NoConstructibleChange().GetCoin(coins);
            
            Assert.Equal(expected, result);
        }
    }
}