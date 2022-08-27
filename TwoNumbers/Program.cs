using System;

namespace AIE
{
    class Program
    {
        public static void Main()
        {
            // Adding Two Numbers
            Console.WriteLine("Enter first number.");
            string num1 = Console.ReadLine();
            float add1;
            float.TryParse(num1, out add1);

            Console.WriteLine("Enter second number.");
            string num2 = Console.ReadLine();
            float add2;
            float.TryParse(num2, out add2);

            float subtotal = add1 + add2;
            int total = (int)subtotal;

            Console.WriteLine(total);
        }
    }
}