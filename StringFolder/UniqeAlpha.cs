using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class UniqeAlpha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            Console.WriteLine("Unique String is : ");
            String result = "";

            foreach(char ch in str)
            {
                if (!result.Contains(ch))
                    result = result + ch;
            }
            Console.WriteLine(result);
        }
    }
}
