using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class Frequenc
    {
        static void Main(string[] args)
        {
            String str = "aabbggcchrgg";

            char c = 'a';

            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine("Frequence of Character is : " + count);
        }
    }
}
