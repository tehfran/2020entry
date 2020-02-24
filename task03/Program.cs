using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateWordChecker
{
    public class DupeChecker
    {
        public static List<string> NonDupeFinder(string s) //Можно было бы использовать List.Select.Distinct(); или HashSet.
        {
            string[] separator = { " ", ",", ".", "!" };

            List<string> splitString = s.ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> nonDupeList = new List<string>();

            Dictionary<string, bool> wordBase = new Dictionary<string, bool>();

            foreach (string word in splitString)
            {
                if (!wordBase.ContainsKey(word))
                {
                    wordBase.Add(word, true);
                }
                else
                {
                    wordBase[word] = false;
                }
            }
            foreach (KeyValuePair<string,bool> kvp in wordBase)
            {
                if (kvp.Value == true) 
                {
                    nonDupeList.Add(kvp.Key);
                }
            }
            return nonDupeList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            //string s = "Sphinx of black quartz, judge my vow";
            //string s = "Don't trouble trouble till trouble troubles you";
            foreach (string word in NonDupeFinder(s))
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();
        }
    }
}
