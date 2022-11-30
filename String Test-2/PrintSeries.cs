using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrString_Test
{
    class PrintSeries
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 30, 68, 130 };

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
