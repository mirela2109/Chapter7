using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arraysEqual = true;

            Console.Write("Въведете дължината на първия масив: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Въведете елемент {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nВъведете дължината на втория масив: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nМасивите са с различни дължини.");
            else
            {
                int[] arrB = new int[length];

                for (int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Въведете елемент {0}: ", i);
                    arrB[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        Console.WriteLine("\nМасивите са различни.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nМасивите са еднакви.");
            }
        }
    }
    
}
