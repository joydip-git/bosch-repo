using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class WordFinder
    {
        private static char[] FindSeparators(string sentence)
        {
            HashSet<char> separators = new HashSet<char>();
            foreach (char ch in sentence)
            {
                if (!char.IsLetter(ch) && !char.IsDigit(ch))
                {
                    separators.Add(ch);
                }
            }
            return separators.ToArray();
        }
        public static SortedList<string, int> GetWordCount(string sentence)
        {
            char[] separators = FindSeparators(sentence);
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            SortedList<string, int> result = new SortedList<string, int>();
            foreach (string item in words)
            {
                if (!result.ContainsKey(item.ToLower()))
                {
                    result.Add(item.ToLower(), 1);
                }
                else
                {
                    int count = result[item.ToLower()];
                    result[item.ToLower()] = count + 1;
                }
            }
            return result;
        }
    }
}
