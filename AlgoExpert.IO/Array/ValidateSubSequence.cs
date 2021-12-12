using System.Collections.Generic;

namespace AlgoExpert.IO.Array
{
    public class ValidateSubSequence
    {
        /// <summary>
        /// Question: https://www.algoexpert.io/questions/Validate%20Subsequence
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sequence"></param>
        /// <returns>bool</returns>
        public  bool IsValid(List<int> array, List<int> sequence)
        {
            var indexSubSequence = 0;
            var boundSequence = 0;

            foreach (var item in array)
            {
                if (item != sequence[indexSubSequence]) continue;

                indexSubSequence++;
                boundSequence++;

                if (boundSequence == sequence.Count) return true;
            }

            return false;
        }
    }
}