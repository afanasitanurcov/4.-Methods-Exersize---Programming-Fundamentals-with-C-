using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "END")
                {
                    return;
                }
                char[] input = str.ToCharArray();

                char[] reverse = input.Reverse().ToArray();

                bool isEqual = Enumerable.SequenceEqual(input, reverse);

                if (isEqual)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
