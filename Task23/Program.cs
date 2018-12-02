using System;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Въведете K: ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[k];

            recSolution(arr, 0);
        }

        static void recSolution(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    recSolution(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
