using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class SmallestDifferenceTest
    {
        [Fact]
        public void ValidateSmallestDifferenceTest()
        {
            var array = new int[] {-1, 5, 10, 20, 28, 3};
            var array2 = new int[] {26,134,135,15,17};
            var result = new SmallestDifference().GetSmallest(array, array2);
            
            Assert.Equal(new int[2] {28,26}, result);
        }
    }
}