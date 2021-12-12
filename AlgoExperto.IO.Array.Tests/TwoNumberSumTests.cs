using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class TwoNumberSumTests
    {
        [Theory]
        [InlineData(10, new int[] {-1, 11})]
        public void ValidateTargetSumWithBetterSolution(int target, int[] expected)
        {
            var array = new int[]
            {
                3,5,-4,8,11,-1,6
            };
            
            var result = new TwoNumberSum().ExecuteMostFast(array, target);
            
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(10, new int[] {-1, 11})]
        public void ValidateTargetSumWithAverageSolution(int target, int[] expected)
        {
            var array = new int[]
            {
                3,5,-4,8,11,-1,6
            };
            
            var result = new TwoNumberSum().Execute(array, target);
            
            Assert.Equal(expected, result);
        }
    }
}