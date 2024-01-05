using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] firstArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = new int[firstArray.Length];

            int index = int.Parse(Console.ReadLine());

            splitArray(firstArray, secondArray, index);
                                 
            
            Console.WriteLine("gg");
            Console.ReadKey();

        }
        static int[] splitArray(int[] firstArray, int[] secondArray, int index)
        {
            if (CheckForOutOfRange(firstArray, index))
            {
                Console.WriteLine("Invalid index");
            }

            for (int i = 0; i < firstArray.Length - index - 1; i++)
            {
                secondArray[i] = firstArray[i + index + 1];
            }

            for (int i = index; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i - index];
            }
            return secondArray;
        }
        static bool CheckForOutOfRange(int[] array, int index)
        {
            return index < 0 || index >= array.Length;
        }
        static int findMaxOdd(int[] array)
        {

            int oddMax = array.Where(i => i % 2 == 1).Max();
            int indexOddMax = Array.LastIndexOf(array, oddMax);
            return indexOddMax;

        }
        static int findMinOdd(int[] array)
        {

            int oddMin = array.Where(i => i % 2 == 1).Min();

            int indexOddMin = Array.LastIndexOf(array, oddMin);
            return indexOddMin;

        }
        static int findMaxEven(int[] array)
        {

            int EvenMax = array.Where(i => i % 2 == 0).Max();

            int indexEvenMax = Array.LastIndexOf(array, EvenMax);
            return indexEvenMax;

        }
        static int findMinEven(int[] array)
        {

            int evenMin = array.Where(i => i % 2 == 0).Min();

            int indexEvenMin = Array.LastIndexOf(array, evenMin);
            return indexEvenMin;

        }


    }
}
