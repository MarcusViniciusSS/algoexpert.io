

namespace AlgoExpert.IO.Strings
{
    public class RunLengthEncoding
    {
        public string Apply(string str)
        {
            var text = string.Empty;
            char current = str[0];
            var count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (current == str[i])
                {
                    count++;

                    if (count == 9)
                    {
                        text += $"{count}{str[i]}";
                        count = 0;
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        count = 1;
                        current = str[i];
                        continue;
                    };

                    text += $"{count}{current}";
                    count = 1;
                    current = str[i];
                }

                if ((i + 1) < str.Length) continue;

                text += $"{count}{current}";
            }
            
            return text;
        }
    }
}