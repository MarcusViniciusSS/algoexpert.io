using System.Collections.Generic;
using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class MoveElementToEndTest
    {
        [Fact]
        public void ValidateMoveElementToEndTest()
        {
            var list = new List<int>
            {
                2, 1, 2, 2, 2, 3, 4, 2
            };
            
            var expected = new List<int>
            {
               4,1,3,2,2,2,2,2
            };

            var toMove = 2;
            
            var result = new MoveElementToEnd().Execute(list, toMove);
            
            Assert.Equal(expected, result);
        }
    }
}