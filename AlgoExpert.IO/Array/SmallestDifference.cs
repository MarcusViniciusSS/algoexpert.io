using System;

namespace AlgoExpert.IO.Array
{
    public class SmallestDifference
    {
        /// <summary>
        /// https://www.algoexpert.io/questions/Smallest%20Difference
        /// </summary>
        /// <param name="arrayOne"></param>
        /// <param name="arrayTwo"></param>
        /// <returns></returns>
        public int[] GetSmallest(int[] arrayOne, int[] arrayTwo)
        {
            var smallest = int.MaxValue;
            var smallestArray = new int[2];
            var diff = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    diff = GetDifference(arrayOne[i], arrayTwo[j]);
                    if (smallest < diff) continue;

                    smallest = diff;
                    smallestArray[0] = arrayOne[i];
                    smallestArray[1] = arrayTwo[j];
                }
            }

            return smallestArray;
        }

        private int GetDifference(int a, int b)
        {
            return  Math.Abs(b + (-a));
        }
    }
}