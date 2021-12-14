using System.Linq;
using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class ValidateSubSequenceTests
    {
        [Theory]
        [InlineData(new int[] {3,5,-4,8,11,-1,6}, new int[] { 11, -1}, true)]
        [InlineData(new int[] {5,1,22,25,6,-1,8,10}, new int[] { 1, 6, -1, 10}, true)]
        [InlineData(new int[] {5,1,22,25,6,-1,8,10}, new int[] { 1, 6, -1, -10}, false)]
        public void ValidateSubSequenceWithBetterSolution(int[] array, int[] sequence, bool expected)
        {
            var result = new ValidateSubSequence().IsValid(array.ToList(), sequence.ToList());
            
            Assert.Equal(expected, result);
        }
    }
}