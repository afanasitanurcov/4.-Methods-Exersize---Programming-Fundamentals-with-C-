using System;
using System.Drawing;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char letter;
            string word = Console.ReadLine();
            char[] a = word.ToCharArray();
            
            for (int i = 0; i < a.Length; i++)
            {
                letter = a[i];

                if (letter == 'a' || letter =='A' || letter == 'e' || letter == 'E' || letter == 'u'|| letter == 'U' || letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O')
                {
                    count++;
                }
            }
            Console.WriteLine(count);


        }
    }
}

