using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong first = ulong.Parse(Console.ReadLine());
            ulong second = ulong.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", (double)Factorial(first) / Factorial(second));

            ulong Factorial(ulong number)
            {
                if (number < 1)
                {
                    return 1;
                }
                return number * Factorial(number - 1);
            }
        }
    }
}
