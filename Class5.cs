using System;

namespace parctical
{
    internal class Class5
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int i, sum = 0;
            float avg;

            for (i = 0; i < 5; i++)
            {
                sum += arr[i];
            }

            avg = sum / 5.0f;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + avg);
        }
    }
}
