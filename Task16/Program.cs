using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете елемнт {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведете число: ");
            int number = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, number);

            if (index >= 0) Console.Write("Числото е на {0} индекс.", index);
            else Console.Write("Числото не е намерено.");
        }
    }
}
