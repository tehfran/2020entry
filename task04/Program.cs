using System;

namespace FactorialCalculation
{
    class FactorialCalc
    {
        public static long Factorial(long n)  //Классическое школьно-олимпиадное решение: int[] f = new int[] {1, 2, 6, 24, ...}; return f[i];
        {
            if (n >= 1)
            {
                return n * Factorial(n - 1); //Рекурсия
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)

        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FactorialCalc.Factorial(n));
        }
    }
}
