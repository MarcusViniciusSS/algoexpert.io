using System.Collections.Generic;

namespace AlgoExpert.IO.Strings
{
    public class GenerateDocument
    {
        public bool CanCreate(string characters, string document)
        {
            var list = new List<char>();
            var qtd = characters.Length;
            var end = document.Length - 1;

            if (string.IsNullOrEmpty(document)) return true;

            for (int i = 0; i < qtd; i++)
            {
                var index = characters.IndexOf(document[0]);
                
                if (index != -1)
                {
                    list.Add(document[0]);
                    document = document.Substring(1, end);
                    characters = characters.Remove(index, 1);
                    end--;
                }

                if (document.Length == 0) return true;
            }
            
            return false;
        }
    }
}