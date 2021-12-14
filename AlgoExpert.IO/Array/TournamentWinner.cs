using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert.IO.Array
{
    public class TournamentWinner
    {
        /// <summary>
        /// Question: https://www.algoexpert.io/questions/Tournament%20Winner
        /// </summary>
        /// <param name="competitions"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public string WhoWinner(List<List<string>> competitions, List<int> results)
        {
            var homeTeamWon = 1;
            var ranking = new Dictionary<string, int>(competitions.Count);

            for (int i = 0; i < competitions.Count; i++)
            {
                var whoWon = results[i];

                if (whoWon == homeTeamWon)
                {
                    if (!ranking.ContainsKey(competitions[i][0]))
                    {
                        ranking.Add(competitions[i][0], 3);
                    }
                    else
                    {
                        ranking[competitions[i][0]] += 3;
                    }
                }
                else
                {
                    if (!ranking.ContainsKey(competitions[i][1]))
                    {
                        ranking.Add(competitions[i][1], 3);
                    }
                    else
                    {
                        ranking[competitions[i][1]] += 3;
                    }
                }
            }

            return ranking.FirstOrDefault(item => item.Value == ranking.Values.Max()).Key;
        }
    }
}