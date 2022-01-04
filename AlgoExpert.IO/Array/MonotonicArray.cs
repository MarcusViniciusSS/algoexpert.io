using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert.IO.Array
{
    public class MonotonicArray
    {
        /// <summary>
        /// https://www.algoexpert.io/questions/Monotonic%20Array
        /// </summary>
        /// <returns></returns>
        public bool Is(int[] array)
        {
            bool isNonincreasing = true;
            bool isNondecreasing = true;

            if (array.Length <= 1) return true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    isNondecreasing = false;
                }
                if(array[i] > array[i - 1])
                {
                    isNonincreasing = false;
                }
            }

            return isNonincreasing || isNondecreasing;
        }
    }
}