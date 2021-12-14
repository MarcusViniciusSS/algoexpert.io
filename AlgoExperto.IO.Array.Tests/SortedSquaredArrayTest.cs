using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class SortedSquaredArrayTest
    {
        [Theory]
        [InlineData(new int[]{ 1,2 }, new int []{1,4})]
        [InlineData(new int[]{1, 2, 3, 5, 6, 8, 9}, new int []{1, 4, 9, 25, 36, 64, 81})]
        [InlineData(new int[]{0}, new int []{0})]
        [InlineData(new int[]{-3, -2, -1}, new int []{1,4,9})]
        public void ValidateSortedSquaredWithBetterSolution(int[] array, int[] expected)
        {
            var result = new SortedSquaredArray().ApplyMostPerformace(array);
            
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(new int[]{ 1,2 }, new int []{1,4})]
        [InlineData(new int[]{1, 2, 3, 5, 6, 8, 9}, new int []{1, 4, 9, 25, 36, 64, 81})]
        [InlineData(new int[]{0}, new int []{0})]
        [InlineData(new int[]{-3, -2, -1}, new int []{1,4,9})]
        public void ValidateSortedSquaredWithAvarageSolution(int[] array, int[] expected)
        {
            var result = new SortedSquaredArray().Apply(array);
            
            Assert.Equal(expected, result);
        }
    }
}