using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_.NET_Tutorial_1
{
    internal class upper_characters
    {
        static void Main(string[] args)
        {
            string name, upperName;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            upperName = name.ToUpper();

            Console.WriteLine("OUTPUT: " + upperName);

            Console.ReadLine();
        }
    }
 }

