using System;

namespace AIE
{
    class Program
    {
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] numbers = { 32, 97, 48, 78, 12 };

            bubbleSort(numbers);
            Console.WriteLine("Sorted array");
            printArray(numbers);
        }
    }
}