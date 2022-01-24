namespace AlgoExpert.IO.Strings
{
    public class FirstNonRepeatingCharacter
    {
        public int GetIndexCharacter(string str)
        {
            foreach (var letter in str)
            {
                var occurence = Occurrences(letter, str);

                if (occurence == 1) return str.IndexOf(letter);
            }
            
            return -1;
        }

        private int Occurrences(char letter, string str)
        {
            var count = 0;

            foreach (var text in str)
            {
                if (count > 1)
                {
                    return count;
                };
                
                if (text == letter)
                {
                    count++;
                }
            }
            
            return count > 1 ? count : 1;
        }
    }
}