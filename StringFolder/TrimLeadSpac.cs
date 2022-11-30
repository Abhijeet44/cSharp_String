using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class TrimLeadSpac
    {
        static void Main(string[] args)
        {
            String str = "   Abhi";

            char[] chartoTrim = { ' ' };

            Console.WriteLine("Before Trim : " + str);
            Console.WriteLine("After Trim : " + str.Trim(chartoTrim));
        }
    }
}
