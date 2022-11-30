using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class HighestFreqchar
    {
        // Highest Frequence Character in a String 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            int max = 0;
            char maxChar = ' ';


            int[] arr = new int[256];

            for(int i = 0; i < str.Length; i++)
            {
                arr[str[i]]++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if(max < arr[str[i]])
                {
                    max = arr[str[i]];
                    maxChar = str[i];
                }
            }
            Console.WriteLine(maxChar);
           
        }
    }
}
