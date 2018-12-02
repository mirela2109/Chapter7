using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете S:");
            int S = int.Parse(Console.ReadLine());
            Console.Write("Въведете N:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int subsetsCount = (int)Math.Pow(2, n);
            for (int i = 1; i < subsetsCount; i++)
            {
                int sum = 0;
                int bitsOfI = i;
                for (int j = 0; j < n; j++)
                {
                    if (bitsOfI % 2 == 1)
                    {
                        sum += array[j];
                    }
                    bitsOfI = bitsOfI >> 1;
                }
                if (sum == S)
                {
                    Console.WriteLine("True");
                    return;
                }
            }
            Console.WriteLine("False");

        }
    }
}
