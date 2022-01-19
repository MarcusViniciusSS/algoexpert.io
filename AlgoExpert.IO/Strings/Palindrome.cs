namespace AlgoExpert.IO.Strings
{
    public class Palindrome
    {
        public bool Is(string str)
        {
            var start = 0;
            var end = str.Length - 1;

            while (start <= (str.Length - 1))
            {
                if (str[start] != str[end]) return false;

                start++;
                end--;
            }
            
            return true;
        }
    }
}