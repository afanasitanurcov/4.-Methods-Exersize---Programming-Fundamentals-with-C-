using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (isTop(i))
                {
                    Console.WriteLine(i);
                }
            }

        }


        static bool isTop(int n)
        {
            if (isFirstCondition(n) && isSecondCondirion(n))
            {
                return true;

            }
            return false;
        }



        static bool isFirstCondition(int number)
        {
            int s = 0;
            while (number > 0)
            {
                s = s + number % 10; number = number / 10;

            }
            return s % 8 == 0;

        }
        static bool isSecondCondirion(int number)
        {

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                number = number / 10;

            }
            return false;
        }
    }
}
