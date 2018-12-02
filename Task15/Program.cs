using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Въведете дума: ");
            char[] word = (Console.ReadLine()).ToCharArray();

            for (int i = 0; i < word.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (word[i] == alphabet[j]) Console.Write("{0} ", j);
        }
    }
}
