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

            CalculateArray(array1, array2, array3);

        }

        public static void CalculateArray(int[] array1, int[] array2, int[] array3)
        {

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            Console.WriteLine($"#1 Array Sum: {sum1}");



            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }

            Console.WriteLine($"#2 Array Sum: {sum2}");



            for (int i = 0; i < array3.Length; i++)
            {
                sum3 += array3[i];
            }

            Console.WriteLine($"#3 Array Sum: {sum3}");
        }

    }
}

