
using System;

namespace AlgoExpert.IO.Array
{
    public class SortedSquaredArray
    {
        /// <summary>
        /// https://www.algoexpert.io/questions/Sorted%20Squared%20Array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] Apply(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }

            System.Array.Sort(array);
            
            return array;
        }
        
        /// <summary>
        /// https://www.algoexpert.io/questions/Sorted%20Squared%20Array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] ApplyMostPerformace(int[] array)
        {
            var pointerRight = array.Length - 1;
            var pointerLeft = 0;
            var orderdArray = new int[array.Length];
            var index = array.Length - 1;

            while (index >= 0)
            {
                var leftItem = Math.Abs(array[pointerLeft] * array[pointerLeft]);
                var rightItem = Math.Abs(array[pointerRight] * array[pointerRight]);

                if (leftItem > rightItem)
                {
                    orderdArray[index] = leftItem;
                    pointerLeft++;
                }
                else
                {
                    orderdArray[index] = rightItem;
                    pointerRight--;
                }
                
                index--;
            }

            return orderdArray;
        }
    }
}

