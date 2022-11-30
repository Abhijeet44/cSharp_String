using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class ChkEmailId
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Email-Id : ");
            String str = Console.ReadLine();

            int a = str.IndexOf('.');
            int b = str.IndexOf('@');
            
            if(a>b)
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("Invali Email");
        }
    }
}
