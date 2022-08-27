using System;

namespace AIE
{
    class Program
    {
        public static void Main()
        {
            //FizzBuzz
            Console.WriteLine("Enter a number.");
            string numberInput = Console.ReadLine();
            int userNumber;
            int.TryParse(numberInput, out userNumber);

            for (int j = userNumber; j < userNumber + 5; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (j % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}