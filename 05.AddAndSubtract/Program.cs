using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int sum = sumFirstAndSecond(number1, number2);
            
            int result = substraction(sum, number3);

            Console.WriteLine(result);

        }
        static int sumFirstAndSecond(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
            
        }
        static int substraction (int sum, int number3)
        {
            int result = sum - number3;
           return result;
        }
    }
}
