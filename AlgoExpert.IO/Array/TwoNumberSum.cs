using System.Collections.Generic;

namespace AlgoExpert.IO.Array
{
    public class TwoNumberSum
    {
        // Big O Complexity T(O(n)) S(O (n))
        /// <summary>
        /// Question: https://www.algoexpert.io/questions/Two%20Number%20Sum
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns>int[]</returns>
        public int[] Execute(int[] array, int targetSum)
        {
            var dictionary = new Dictionary<int, bool>(array.Length);

            foreach (var x in array)
            {
                var y = targetSum - x;

                if (dictionary.ContainsKey(y))
                {
                    return new[] {x, y};
                }
                
                dictionary.Add(x, true);
            }
          
            return System.Array.Empty<int>();
        }
        
        // Big O Complexity T(O(nlog(n))) S(O(1))
        /// <summary>
        /// Question: https://www.algoexpert.io/questions/Two%20Number%20Sum
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public int[] ExecuteMostFast(int[] array, int targetSum)
        {
            System.Array.Sort(array, (a, b) => a.CompareTo(b));
            
            var rightPosition = array.Length - 1;
            var leftPosition = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (leftPosition == rightPosition) break;
                
                var result = array[leftPosition] + array[rightPosition];

                if (result == targetSum) return new[] {array[leftPosition], array[rightPosition]};
                if (result < targetSum) leftPosition++;
                if (result > targetSum) rightPosition--;
            }
          
            return System.Array.Empty<int>();
        }
    }
}