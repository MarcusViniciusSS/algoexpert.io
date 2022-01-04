using System.Collections.Generic;
using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class MonotonicArrayTest
    {
        [Fact]
        public void ValidateMonotonicArrayTest()
        {
            var list = new int[]
            {
               -1, -5,-10,-1100,-1100,-1101,-1102,-9001
            };

            var result = new MonotonicArray().Is(list);
            
            Assert.True(result);
        }
    }
}