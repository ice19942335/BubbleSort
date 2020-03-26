using System;
using System.Threading;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] arr = new int[20];
            int temp;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(1, 100);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }

                PrintArray(arr);
            }
        }

        private static void PrintArray(int[] arr)
        {
            Console.Clear();

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Thread.Sleep(100);
        }
    }
}
