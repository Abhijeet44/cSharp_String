using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class DemoStr
    {
        static void Main(string[] args)
        {
            String s1 = "Abhi";
            String s2 = "Abhi";

            Console.WriteLine(s1==s2);
            Console.WriteLine(Object.ReferenceEquals(s1,s2));

            String str1 = new string("Om");
            String str2 = new string("Om");

            Console.WriteLine(str1==str2);
            Console.WriteLine(Object.ReferenceEquals(str1,str2));


        }
    }
}
