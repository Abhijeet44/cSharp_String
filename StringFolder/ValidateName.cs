using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class ValidateName
    {
        static bool chkName(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] > 'a' && str[i] < 'z' || str[i] > 'A' && str[i] < 'Z')
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name : ");
            String name = Console.ReadLine();

            bool result = chkName(name);
            if(result==true)
                Console.WriteLine("Valid Name");
            else
                Console.WriteLine("Invalid Name");
        }
    }
}
