using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class FirstOccurance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            String str = Console.ReadLine();

            Console.WriteLine("Enter a Character to find Index : ");
            char ch = Convert.ToChar(Console.ReadLine());

            int index = str.IndexOf(ch);
            Console.WriteLine("Index of Character is : " + index);
        }
    }
}
