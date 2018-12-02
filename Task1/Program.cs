using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете x:");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            for (int i = 0; i < x; i++)
            {
                a[i] = i * 5;
                Console.WriteLine(a[i]);
            }

        }
    }
}
