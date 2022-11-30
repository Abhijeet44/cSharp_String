using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class NumOfOccur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            Console.WriteLine("Enter a Character to find occurances : ");
            char ch = Convert.ToChar(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    count++;
            }
            Console.WriteLine("Number of Occurances : " + count);

        }
    }
}
