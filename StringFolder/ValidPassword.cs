using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringFolder
{
    class ValidPassword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Password : ");
            String password = Console.ReadLine();

            if(password.Length < 8)
                Console.WriteLine("Invalid Password !");
            
            

            
        }
    }
}
