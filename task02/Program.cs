using System;

namespace NumSearch
{
    public class NumSearch
    {
        public static bool HasDigit(int[] a, int n)  //Можно было использовать Array.Exists()
        {
            foreach (int i in a)
            {
                if (i == n)
                {
                    return true;
                }
                else if (i > n)
                {
                    return false;
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 5, 6, 7, 8, 11 };
            int i = 4;
            Console.WriteLine(HasDigit(a, i));
        }
    }
}
