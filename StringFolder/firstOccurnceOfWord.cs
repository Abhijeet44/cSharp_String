using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class firstOccurnceOfWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            String str = Console.ReadLine();

            Console.WriteLine("Enter a word to find Occurance : ");
            String word = Console.ReadLine();

            String[] arr = str.Split();

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == word)
                {
                    Console.WriteLine("First Occurance is : " + i);
                    break;
                }
            }
        }
    }
}
