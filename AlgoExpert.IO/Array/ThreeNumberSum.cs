using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert.IO.Array
{
    public class ThreeNumberSum
    {
        /// <summary>
        /// https://www.algoexpert.io/questions/Three%20Number%20Sum
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public List<int[]> GetThreeNumberSum(int[] array, int targetSum)
        {
            System.Array.Sort(array);
            var threeNumberSums = new List<int[]>(array.Length);
            int[] subArray;
            var rightPosition = 0;
            var leftPosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                subArray = array.Skip(i + 1).Take(array.Length - (i  + 1)).ToArray();
                rightPosition = subArray.Length - 1;
                leftPosition = 0;
                
                foreach (var t in subArray)
                {
                    if (leftPosition == rightPosition || leftPosition > rightPosition) break;
                    
                    var result = subArray[leftPosition] + subArray[rightPosition] + array[i];
                    
                    if (result == targetSum)
                    {
                        threeNumberSums.Add(new[] { array[i], subArray[leftPosition], subArray[rightPosition]});
                        leftPosition++;
                        rightPosition--;
                        continue;;
                    }
                    if (result < targetSum) leftPosition++;
                    if (result > targetSum) rightPosition--;
                }
            }
            
            return threeNumberSums;
        }
    }
}