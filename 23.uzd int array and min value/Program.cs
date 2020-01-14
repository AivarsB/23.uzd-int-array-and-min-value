using System;

namespace _23.uzd_int_array_and_min_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5, 6, 7, 1, 8, 9 };
            var minValue = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < minValue)
                {
                    minValue = number;
                }
            }

            Console.WriteLine(minValue);
        }
    }
}
