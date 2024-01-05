using System;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int result = 0;
            string str = Console.ReadLine();
            char[] word = str.ToCharArray();
            int a = word.Length;
            if (a % 2 == 0)
            {
                even(a, word);

            }
            else
            {
                odd(a, word);

            }

            static void even(int a, char[] word)
            {
                int result = a / 2;
                Console.WriteLine($"{word[result - 1]}{word[result]}");
            }
            static void odd(int a, char[] word)
            {
                int result = a / 2;
                Console.WriteLine($"{word[result]}");
            }
        }
    }
}
