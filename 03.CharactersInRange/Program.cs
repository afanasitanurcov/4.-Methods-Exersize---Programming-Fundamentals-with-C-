using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)

        {
              string a = Console.ReadLine();
            char[] aa = a.ToCharArray();
           
            string b = Console.ReadLine();
            char[] bb = b.ToCharArray();
            
            int countStart = 0;

            int countEnd = 0;
            for (int i = 0; i <= 127; i++)
            {
              if  ((char)i == aa[0])
              {
                    break;
              }
                    countStart++;
                
            }


            for (int i = 0; i <= 127; i++)
            {
                if ((char)i == bb[0])
                {
                    break;
                }
                    countEnd++;
            }

            char end;
            char start;
            if (countEnd < countStart)
            {
                char star = bb[0];
                char en = aa[0];
                start = star;
                end = en;
            }
            else
            {
                char star = aa[0];

                char en = bb[0];
                start = star;
                end = en;
            }
            
            
            for (int i = 0; i <= 127; i++)
            {
                if ((char)i == start) 
                {
                   for (int j = i; ; j++)
                    {
                        Console.Write((char)(j + 1) + " ");
                        if ((char)(j+2) == end)
                        {
                            return;
                        }
                    }
                }

            }
            
            

            

        }

        
    }
}
