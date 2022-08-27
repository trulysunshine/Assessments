using System;

namespace AIE
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int size = numbers.Length;

            int sumNumbers = 0;
            Array.ForEach(numbers, i => sumNumbers += i);

            Console.WriteLine(sumNumbers);
        }
    }
}