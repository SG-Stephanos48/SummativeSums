using System;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] array2 = { 999, -60, -77, 14, 160, 301 };
            int[] array3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

            CalculateArray(array1);
            CalculateArray(array2);
            CalculateArray(array3);
        }

        public static void CalculateArray(int[] array)
        {

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Array Sum: {sum}");

        }

    }
}

