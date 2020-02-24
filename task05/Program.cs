using System;
using System.Collections.Generic;
using System.Linq;

namespace BalanceCheck
{
    class BalanceChecker
    {
        public static bool IsBalanced(string input) //Возможно, есть решение через регулярные выражения, но этот вариант интуитивен и хорошо читается.
        {
            Dictionary<char, char> sets = new Dictionary<char, char>() 
            {
                { '{', '}' },
                { '(', ')' },
                { '[', ']' }
            };
            Stack<char> parens = new Stack<char>();

            try
            {
                foreach (char c in input)
                {
                    if (sets.Keys.Contains(c))
                    {
                        parens.Push(c);
                    }
                    else
                        if (sets.Values.Contains(c))
                    {
                        if (c == sets[parens.First()])
                        {
                            parens.Pop();
                        }
                        else return false;
                    }
                    else continue;
                }
            }
            catch
            {
                return false;
            }
            return (parens.Count() == 0);

        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(IsBalanced(s));
        }
    }
}
