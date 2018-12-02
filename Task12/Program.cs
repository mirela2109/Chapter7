using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете височина: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write("Въвете ширина: ");
            int x = Int32.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 1; i <= y; i++)
            {
                Console.Write("{0} ", i);

                a += i;

                for (int j = 1; j < x; j++)
                {
                    a += y;
                    Console.Write("{0} ", a);
                }

                a = 0;
                Console.WriteLine();
            }
        }
    }
}
