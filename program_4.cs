﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_.NET_Tutorial_1
{
    internal class program_4
    {
        static void Main(string[] args)
        {
            int x;
            string str;

            Console.WriteLine("Enter Number: ");
            str = Console.ReadLine();

            x = Convert.ToInt32(str);

            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");
            Console.Read();
        }
    }
}
