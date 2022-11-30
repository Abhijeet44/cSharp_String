using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentance : ");
            String str = Console.ReadLine();

            String[] arr = str.Split();

            String maxlength = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > arr[0].Length)
                {
                    maxlength = arr[i];
                }
            }
            Console.WriteLine("Longest word is : " + maxlength);

        }
    }
}
