using System;
using System.Collections;
using System.Collections.Generic;
using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class ThreeNumberSumTest
    {
        [Theory]
        [ClassData(typeof(ThreeNumberSumGenerator))]
        public void ValidateThreeNumberSum(int[] array, int targetSum, List<int[]> expected)
        {
            var result = new ThreeNumberSum().GetThreeNumberSum(array, targetSum: targetSum);
            
            Assert.Equal(expected, result);
        }
    }
    
    public class ThreeNumberSumGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new int[] { 1,2,3,4,5,6,7,8,9,15 }, 32,  new List<int[]> { new []{8,9,15} }};
            yield return new object[] { new int[] { 1, 2, 3 }, 7,  new List<int[]> {}};
            yield return new object[] { new int[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0, new List<int[]>()
            {
                new [] {-8, 2, 6},
                new [] {-8, 3, 5},
                new [] {-6, 1, 5},
            }};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}