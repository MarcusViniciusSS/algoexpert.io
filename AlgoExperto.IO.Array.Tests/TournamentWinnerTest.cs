using System.Collections.Generic;
using System.Linq;
using AlgoExpert.IO.Array;
using Xunit;

namespace AlgoExperto.IO.Array.Tests
{
    public class TournamentWinnerTest
    {
        [Fact]
        public void ValidateTournamentWinnerSolution()
        {
            var competitions = new List<List<string>>
            {
                new() { "HTML", "C#" },
                new() { "C#", "Python" },
                new() { "Python", "C#" },
            };

            var expected = "Python";
            var results = new List<int> {0, 0, 1};

            var result = new TournamentWinner().WhoWinner(competitions, results);

            Assert.Equal(expected, result);
        }
    }
}