using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrString_Test
{
    // Frequence of each digit in given Mobile Number 

    class FreqOfEachDigit
    {
        static bool isAlreadyPr(String str, int cur)
        {
            for (int i = 0; i < cur; i++)
            {
                if (str[i] == str[cur])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            long num = 4254355674;

            String s = num.ToString();
            int[] arr = new int[s.Length];
            int[] arr2 = new int[s.Length];
            int count = 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (isAlreadyPr(s, i) == false)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            count++;
                        }
                    }
                    arr[i] = count;
                    Console.WriteLine("Frequency of " + s[i] + " is : " + arr[i]);
                }
                count = 1;
            }
        }
    }
}
