using System;

namespace AIE
{
    class Program
    {
        public static void Main()
        {

            // Fibonacci
            int n1 = 0, n2 = 1, n3, i;

            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < 9; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
