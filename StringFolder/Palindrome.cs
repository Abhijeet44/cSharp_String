using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String str = Console.ReadLine();

            String rev = "";

            for(int i = str.Length; i >=0 ; i--)
            {
                rev = rev + str[i];
            }

            if (str == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
             
    class Palindrome2
    {
        static void Main(string[] args)
        {
            String str = "cook";

            for(int i = 0; i < str.Length; i++)
            {
                char start = str[0];
                char end = str[str.Length - 1];

                while (start < end)
                {
                    if (start == end)
                    {
                        start++;
                        end--;
                    }
                    else  
                        Console.WriteLine("Not Palindrome");
                        break;
                    
                }
            }
            Console.WriteLine("Palindrome");
        }
    }
}
