using System;

namespace ShellSort
{
    public delegate bool Func<T>(T a, T b);

    public class ShellSort
    {
        public static int[] Sort(int[] input) //Метод Шелла. Можно было использовать Array.Sort()
        {
            int n = input.Length;
            int h = n / 2;
            int[] output = input;

            while (h > 0)
            {
                for (int i = 0; i + h < n; i++)
                {
                    int j = i + h;
                    int t = output[j];

                    while (j - h >= 0 && t < output[j - h])
                    {
                        output[j] = output[j - h];
                        j -= h;
                    }

                    output[j] = t;
                }

                h /= 2;
            }
            return output;        
        }
        public static void Main(string[] args)
        {
            int[] array = new int[] { 13, 5, 23, 1, 56, 2, 7 };
            int[] sortedArray = Sort(array);
            foreach (int i in sortedArray)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
