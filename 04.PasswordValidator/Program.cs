using System;
using System.Linq;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!isLengthValid(password))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyContainsDigitsAndLetters(password))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ContainsAtLeast2Digits(password))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
           


        }
        static bool isLengthValid(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool OnlyContainsDigitsAndLetters(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        private static bool ContainsAtLeast2Digits(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }


    }
}
