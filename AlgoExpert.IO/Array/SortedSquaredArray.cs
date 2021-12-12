
namespace AlgoExpert.IO.Array
{
    public class SortedSquaredArray
    {
        public int[] Apply(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }

            System.Array.Sort(array);
            
            return array;
        }
    }
}