using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class StrBuilder
    {
        static void Main(string[] args)
        {
            String str = "Abhi";
            StringBuilder sb = new StringBuilder(str);
            sb.Append("Tharun");
            sb.Append("Ranveer");
            Console.WriteLine(sb);
            sb.Insert(0, "Gaurav");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Abhijeet Birajdar");
            Console.WriteLine(sb1);
            sb1.AppendFormat(" is a Student");
            Console.WriteLine(sb1);
            sb1.Insert(0, "Hello");
            Console.WriteLine(sb1);
            sb1.Remove(0, 5);
            Console.WriteLine(sb1);
            sb1.Replace("Student", "Developer");
            Console.WriteLine(sb1);



        }
    }
}
