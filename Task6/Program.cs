using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, tempIndex, tempCounter;

            Console.Write("Въведете дължина на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете елемент {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = tempCounter = 1;
                tempResult[0] = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[j] > tempResult[tempIndex - 2] && arr[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = arr[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);
        }
    }
}
