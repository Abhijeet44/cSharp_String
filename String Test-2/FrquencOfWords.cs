using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrString_Test
{
    class FrquencOfWords
    {
        static void Main(string[] args)
        {
            String str = "Nothing is as easy as it looks Nothing";

            String[] arr = str.Split();

            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && arr[i] != "-1")
                    {
                        arr[j] = "-1";
                        count++;
                    }
                }
                if(count>0 && arr[i]!="-1")
                {
                    Console.WriteLine(arr[i] + " : " + count);
                    arr[i] = "-1";
                }
                count = 1;
            }
        }
    }
}
