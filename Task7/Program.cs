using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Въведете N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете K: ");
            int k = Int32.Parse(Console.ReadLine());
            if (k>n)
            {
                Console.WriteLine("False");
            }
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете елемент {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("\nМаксималната сума: {0}", sum);
        }
    }
}
