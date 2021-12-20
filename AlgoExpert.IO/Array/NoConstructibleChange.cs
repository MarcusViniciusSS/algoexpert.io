using System;

namespace AlgoExpert.IO.Array
{
    public class NoConstructibleChange
    {
        /// <summary>
        /// https://www.algoexpert.io/questions/Non-Constructible%20Change
        /// </summary>
        /// <param name="coins"></param>
        /// <returns></returns>
        public int GetCoin(int[] coins)
        {
            var change = 0;
            System.Array.Sort(coins);
            
            foreach (var coin in coins)
            {
                if (coin > change + 1)
                {
                    return ++change;
                }

                change += coin;
            }

            return ++change;
        }
    }
}