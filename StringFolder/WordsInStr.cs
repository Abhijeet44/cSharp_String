using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class WordsInStr
    {
        //Number of Words in Strings
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            String[] arr = str.Split();
            Console.WriteLine("Number of Words are : " + arr.Length);
        }
    }
}
