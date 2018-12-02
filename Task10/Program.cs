using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tempCounter = 1, foundNumber = 0;

            Console.Write("Въведете дължина на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете елемент {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arr[i];
                }
            }

            Console.WriteLine("Числото {0} се повтаря {1} пъти.", foundNumber, counter);
        }
    }
}
