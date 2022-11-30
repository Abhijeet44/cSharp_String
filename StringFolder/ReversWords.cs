using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class ReversWords
    {
        public static String Reverse(String s)
        {
            String[] arr = s.Split();
            string result = "";
            for(int i = 0; i < arr.Length; i++)
            {
                String word = arr[i];
                String reverse = "";
                for(int j = word.Length - 1; j >= 0; j--)
                {
                    reverse = reverse + word[j];
                }
                result = result + reverse + " ";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            String str = Console.ReadLine();

            String newstr = Reverse(str);
            Console.WriteLine(newstr);
        }
    }
}
