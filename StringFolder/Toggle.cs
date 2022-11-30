using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class Toggle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            String tog = "";

            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    tog = tog + char.IsLower(str[i]);
                }
                else if(char.IsLower(str[i]))
                {
                    tog = tog + char.IsUpper(str[i]);
                }
            }
            Console.WriteLine(tog);
        }
    }
}
