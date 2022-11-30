using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrString_Test
{
    class CommonChar
    {
        static void Main(string[] args)
        {
            String str1 = "thinsticks";
            String str2 = "thickbricks";

            String result = "";

            // Collecting all common elements in result
           for(int i = 0; i < str1.Length; i++)
           { 
              for (int j = 0; j < str2.Length; j++)
              {
                    if (str1[i] == str2[j])
                        result = result + str1[i];
              }  
           }

            String uniq = "";
            //Removing all Repeated Characters 
            foreach(char ch in result)
            {
                if (!uniq.Contains(ch))
                    uniq = uniq + ch;
            }

            //Printing in Alphabetial Order
            for(char i = 'a'; i <='z'; i++)
            {
                if(uniq.Contains(i))
                    Console.WriteLine(i);
            }
        }
    }
}
