using System.Collections.Generic;

namespace AlgoExpert.IO.Array
{
    public class MoveElementToEnd
    {
        /// <summary>
        /// https://www.algoexpert.io/questions/Move%20Element%20To%20End
        /// </summary>
        /// <returns></returns>
        public List<int> Execute(List<int> array, int toMove)
        {
            int leftPointer = 0;
            int rightPointer = array.Count - 1;

            while (leftPointer < rightPointer)
            {
                while (leftPointer < rightPointer && array[rightPointer] == toMove) rightPointer--;
                if (array[leftPointer] == toMove)
                {
                    (array[rightPointer], array[leftPointer]) = (array[leftPointer], array[rightPointer]);
                }
                
                leftPointer++;
            }

            return array;
        }
    }
}