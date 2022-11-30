using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class AddNumInStr
    {
        // Add Each number in String
        static void Main(string[] args)
        {
            String str = "af4hy2jk8kl1";
            int sum = 0;
            
            for(int i = 0; i < str.Length; i++)
            {
               if(str[i] >= '0' && str[i] <= '9')
               {
                    sum = sum + str[i] - '0';
               }
            }
            Console.WriteLine("Sum of All Digits : " + sum);
        }
    }
}
