using System;

namespace _01.SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

               if (number <= smallestNumber)
                {

                    smallestNumber = number;
                }

            }
            Console.WriteLine(smallestNumber);
        }
    }
}
